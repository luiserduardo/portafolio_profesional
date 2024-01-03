import cv2
import numpy as np
import pytesseract
from PIL import Image
import datetime
import time
import re
import subprocess

cap = cv2.VideoCapture(0)

texto_placa = ''
placas_reconocidas = []

archivo_placas = open("placas.txt", "a")
archivo_placasN = open("placas_NoRe.txt", "a")

placas_registro = ["P567-390", "567-390", "567 390", "567 390", "P567 390", "P464-096", "464-096", "464 096", "P464 096", "P449-903", "449-903", "449 903", "P449 903", "P684-960", "684-960", "684 960", "P684 960", "P174-993", "174-993", "174 993", "P174 993", "P112-192", "112-192", "112 192", "P112 192"]

umbral_area = 1000

pytesseract.pytesseract.tesseract_cmd = r'C:\Program Files\Tesseract-OCR\tesseract.exe'

# Definir el tiempo mínimo entre detecciones (en segundos)
tiempo_minimo = 0

# Variable para almacenar el tiempo de la última detección
ultimo_tiempo = time.time()

while True:
    ret, fotograma = cap.read()

    altura, ancho, _ = fotograma.shape

    # Definir regiones de interés para el reconocimiento de placas
    x1 = int(ancho / 3)
    x2 = int(x1 * 2)
    y1 = int(altura / 3)
    y2 = int(y1 * 2)

    # Dibujar rectángulos y texto en el fotograma
    cv2.rectangle(fotograma, (185, 340), (500, 420), (0, 0, 0), cv2.FILLED)
    cv2.putText(fotograma, texto_placa[0:8], (240, 400),
                cv2.FONT_HERSHEY_SIMPLEX, 1, (0, 255, 0), 2)

    cv2.rectangle(fotograma, (185, 80), (500, 130), (0, 0, 0), cv2.FILLED)
    cv2.putText(fotograma, 'Procesando Placa', (x1 - 10, y1 - 50),
                cv2.FONT_HERSHEY_SIMPLEX, 1, (0, 255, 0), 1)

    cv2.rectangle(fotograma, (x1, y1), (x2, y2), (0, 255, 0), 1)

    # Realizar la detección solo si ha pasado el tiempo mínimo
    if time.time() - ultimo_tiempo >= tiempo_minimo:

        # Recortar la región de interés para el reconocimiento de placas
        recorte = fotograma[y1:y2, x1:x2]

        # Convertir a escala de grises
        Gris = cv2.cvtColor(recorte, cv2.COLOR_BGR2GRAY)

        # filtrado
        Gris = cv2.bilateralFilter(Gris, 15, 17, 17)

        # Detectar bordes
        bordes = cv2.Canny(Gris, 150, 250)

        # Engrosar borDer
        # bordes = cv2.dilate(bordes, None,iterations=1)

        cv2.imshow('UMBRAL', bordes)

        # Encontrar contornos en los bordes
        contornos, _ = cv2.findContours(
            bordes, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)

        # Ordenar los contornos por área en orden descendente y tomar los primeros 4
        contornos = sorted(contornos, key=cv2.contourArea, reverse=True)[:4]

        #  Inicializamos con valor nulo, no se han encontrado
        contorno_placa = None

        # Encontrar el contorno con 4 vértices de la placa
        for contorno in contornos:
            peri = cv2.arcLength(contorno, True)
            aprox_contorno = cv2.approxPolyDP(contorno, 0.017 * peri, True)

            if len(aprox_contorno) == 4:
                contorno_placa = aprox_contorno
                break

        if contorno_placa is not None:
            # Dibujar contorno de la placa en el fotograma
            cv2.drawContours(fotograma, [contorno_placa], -1, (255, 255, 0), 2)

            # Obtener las coordenadas de la placa
            x, y, ancho, alto = cv2.boundingRect(contorno_placa)

            x_I_placa = x + x1
            y_I_placa = y + y1
            x_F_placa = x + ancho + x1
            y_F_placa = y + alto + y1

            # Recortar la región de la placa
            placa = fotograma[y_I_placa:y_F_placa, x_I_placa:x_F_placa]

            altura_placa, ancho_placa, _ = placa.shape

            matriz_valores = np.zeros((altura_placa, ancho_placa))

            # Obtener los canales de color de la placa
            canal_azul = placa[:, :, 0]
            canal_verde = placa[:, :, 1]
            canal_rojo = placa[:, :, 2]

            # Crear una matriz de valores negativos para resaltar los caracteres de la placa
            matriz_valores = 255 - \
                np.maximum.reduce([canal_rojo, canal_verde, canal_azul])

            # Binarizar la matriz de valores
            _, binarizada = cv2.threshold(
                matriz_valores, 80, 255, cv2.THRESH_BINARY)

            binarizada = Image.fromarray(binarizada)

            # Realizar OCR en la imagen binarizada para obtener el texto de la placa
            texto_placa = pytesseract.image_to_string(
                binarizada, config='--psm 7')
            
            texto_placa = texto_placa.upper()

            if len(texto_placa) >= 5:
                placas_reconocidas.append(texto_placa)

                print("Letras de la placa:", texto_placa)

                # Verificar si la placa está en el registro de placas
                placa_limpia = re.sub(r'[^a-zA-Z0-9]', '', texto_placa)
                placa_en_registro = False

                for placa_reg in placas_registro:
                    placa_reg_limpia = re.sub(r'[^a-zA-Z0-9]', '', placa_reg)
                    if placa_limpia == placa_reg_limpia:
                        placa_en_registro = True
                        break

                if placa_en_registro:
                    # La placa está en el registro
                    now = datetime.datetime.now()
                    fecha_hora = now.strftime("%Y-%m-%d %H:%M:%S")
                    registro = f"Placa: {texto_placa} - Fecha/Hora: {fecha_hora}\n"
                    archivo_placas.write(registro)
                else:
                    # La placa no está en el registro
                    now = datetime.datetime.now()
                    fecha_hora = now.strftime("%Y-%m-%d %H:%M:%S")
                    registro = f"Placa: {texto_placa} - Fecha/Hora: {fecha_hora}\n"
                    archivo_placasN.write(registro)

                # Actualizar el tiempo de la última detección
                ultimo_tiempo = time.time()

    # Mostrar el fotograma con la detección de la placa
    cv2.imshow("DETECCION DE PLACAS", fotograma)

    # Esperar la tecla ESC para salir del bucle
    tecla = cv2.waitKey(1)

    if tecla == 27:
        cap.release()
        archivo_placas.close()
        archivo_placasN.close()
        cv2.destroyAllWindows()
        subprocess.run(['python', 'start.py'])
        break
