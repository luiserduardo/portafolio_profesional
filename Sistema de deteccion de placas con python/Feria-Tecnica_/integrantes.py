import tkinter as tk
import subprocess

def regresar():
    root.destroy()  # Cierra la ventana de inicio
    subprocess.run(['python', 'start.py'])

root = tk.Tk()

root.title ("DETECCION DE PLACAS")
root.geometry("960x540")

imagen_fondo = tk.PhotoImage(file="integrantes.png")

fondo_label = tk.Label(root, image=imagen_fondo)
fondo_label.place(x=0, y=0, relwidth=1, relheight=1)

# Crear el botón "Regresar"
iniciar_btn = tk.Button(root, text="Regresar", command=regresar, foreground="black", background="white", font=("Arial", 18), bd=0, relief=tk.RAISED)
iniciar_btn.place(relx=0.9, rely=0.9, anchor=tk.SE, x=-10, y=-10)

root.mainloop()

