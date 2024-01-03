import tkinter as tk
import subprocess

def iniciar_programa():
    root.destroy()  # Cierra la ventana de inicio
    subprocess.run(['python', 'codigo1.py'])

def integrantes():
    root.destroy()
    subprocess.run(['python', 'integrantes.py'])

root = tk.Tk()

# Configurar la ventana
root.title("DETECCION DE PLACAS")
root.geometry("960x540")

# Cargar imagen de fondo
imagen_fondo = tk.PhotoImage(file="BG.png")

# Crear un widget de etiqueta para mostrar la imagen de fondo
fondo_label = tk.Label(root, image=imagen_fondo)
fondo_label.place(x=0, y=0, relwidth=1, relheight=1)

# Crear el botón "INICIAR"
iniciar_btn = tk.Button(root, text="INICIAR", command=iniciar_programa, foreground="black", background="white", font=("Arial", 30), bd=0, relief=tk.RAISED)
iniciar_btn.place(relx=0.9, rely=0.9, anchor=tk.SE, x=-10, y=-120)

# Crear el boton "INTEGRANTES"
integrantes_btn = tk.Button(root, text="INTEGRANTES", command=integrantes, foreground="black", background="white", font=("Arial", 30), bd=0, relief=tk.RAISED)
integrantes_btn.place(relx=0.9, rely=0.9, anchor=tk.SE, x=-10, y=-10)

root.mainloop()
