# Sistema de Detección de Placas de Vehículos

Este proyecto implementa un sistema de detección de placas de vehículos utilizando OpenCV y Tesseract OCR. El código captura imágenes desde la cámara en tiempo real, procesa la región de interés para reconocimiento de placas, y utiliza OCR para extraer el texto de la placa.

## Requisitos

Asegúrate de tener instaladas las siguientes bibliotecas antes de ejecutar el código:

- OpenCV (`pip install opencv-python`)
- NumPy (`pip install numpy`)
- Pytesseract (`pip install pytesseract`)
- Pillow (`pip install Pillow`)

## Configuración

Ajusta las siguientes variables según sea necesario:

```python
placas_registro = ["P567-390", "567-390", ...]  # Lista de placas registradas
umbral_area = 1000  # Umbral de área para filtrar contornos pequeños
tiempo_minimo = 0  # Tiempo mínimo entre detecciones (en segundos)
