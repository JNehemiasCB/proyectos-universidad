import numpy as np
import matplotlib.pyplot as plt

def step(Z):
    return 1 if Z >= 0 else 0  # Funcion Activacion

# Dataset AND
X = np.array([[0,0],[0,1],[1,0],[1,1]], dtype=float)
y = np.array([0,0,0,1], dtype=float)

class Perceptron:
    def __init__(self, w1=0.356, w2=0.259, b=0.122, lr=0.05):
        self.w = np.array([w1, w2], dtype=float)
        self.b = float(b)  # sesgo
        self.lr = float(lr)

    def predict(self, x):
        z = float(np.dot(self.w, x) + self.b) 
        return step(z), z

    def update(self, x, y_true):
        y_pred, z = self.predict(x)
        err = float(y_true - y_pred)
        # regla de actualizacion
        self.w = self.w + self.lr * err * x 
        self.b = self.b + self.lr * err
        return y_pred, z, err

# Función para graficar la frontera de decisión
def plot_boundary(p, X, y, title=""):
    for i in range(len(X)):
        if y[i] == 0:
            plt.scatter(X[i,0], X[i,1], marker='o')
        else:
            plt.scatter(X[i,0], X[i,1], marker='X')

    x_vals = np.linspace(-0.2, 1.2, 200)
    if abs(p.w[1]) > 1e-9:
        y_vals = -(p.w[0] / (p.w[1] + 1e-12)) * x_vals - p.b / (p.w[1] + 1e-12)
        plt.plot(x_vals, y_vals)
    else:
        if abs(p.w[0]) > 1e-9:
            x_line = p.b / (p.w[0] + 1e-12)
            plt.axvline(x_line)

    plt.xlim(-0.2, 1.2)
    plt.ylim(-0.2, 1.2)
    plt.xlabel("x1")
    plt.ylabel("x2")
    plt.title(title)
    plt.grid(True)
    plt.show()

# -------------------- Demostración manual --------------------
# Inicializar perceptrón
p = Perceptron(w1=0.356, w2=0.259, b=0.122, lr=0.05)
print("==== Estado Inicial ====")
print(f"w1 = {p.w[0]:.3f}, w2 = {p.w[1]:.3f}, b = {p.b:.3f}, lr = {p.lr:.3f}")

# Primer ejemplo de la tabla AND
x_demo = np.array([0,0], dtype=float)
y_demo = 0.0

# Cálculo manual
z = float(np.dot(p.w, x_demo) + p.b)
y_pred = step(z)
err = y_demo - y_pred

print("\n=== Demostración manual — Primer ejemplo (x1=0, x2=0, y=0) ===")
print(f"Suma ponderada: z = w1*x1 + w2*x2 + b = {p.w[0]:.3f}*{x_demo[0]} + {p.w[1]:.3f}*{x_demo[1]} + {p.b:.3f} = {z:.3f}")
print(f"Salida Φ(z) (step): {y_pred}")
print(f"Error: y_true - y_pred = {y_demo:.0f} - {y_pred} = {err:.0f}")

# Actualización manual
w_old = p.w.copy()
b_old = p.b
p.w = p.w + p.lr * err * x_demo
p.b = p.b + p.lr * err

print("\nRegla de actualización:")
print("w := w + η * error * x")
print("b := b + η * error")
print(f"w1: {w_old[0]:.3f} → {p.w[0]:.3f}")
print(f"w2: {w_old[1]:.3f} → {p.w[1]:.3f}")
print(f"b : {b_old:.3f} → {p.b:.3f}  (como x=(0,0), los pesos no cambian en este paso)")

# Graficar frontera tras la primera actualización
plot_boundary(p, X, y, "Frontera tras la 1ª actualización manual")
