import pandas as pd   # Importamos la librería pandas para trabajar con datos en CSV y Excel

# Leer todas las columnas de CSV
df_csv = pd.read_csv("../dataset_pandas.csv")  # Lee todo el archivo CSV y lo guarda en un DataFrame
print(df_csv)  # Imprime todo el contenido del DataFrame

# Leer solo ciertas columnas del CSV
df_csv = pd.read_csv("../dataset_pandas.csv", usecols=['edad', 'email', 'estado'])  
# Lee solo las columnas "edad", "email" y "estado" del CSV
print(df_csv)  # Imprime el DataFrame con esas columnas

# Leer todas las columnas pero saltar el footer (última fila) del CSV
df_csv = pd.read_csv("../dataset_pandas.csv", skipfooter=1, engine="python")  
# Lee todas las filas menos la última (gracias al parámetro skipfooter)
print(df_csv)

# Leer Excel (por defecto lee la primera hoja)
df_xls = pd.read_excel("../dataset_pandas.xlsx")  
# Lee un archivo de Excel y, si no se indica, abre la primera hoja
print(df_xls)

# Leer Excel especificando la hoja
df_xls = pd.read_excel("../dataset_pandas.xlsx", sheet_name="mini_tabla")  
# Lee específicamente la hoja llamada "mini_tabla"
print(df_xls)

# Leer sólo ciertas columnas de la primera hoja de Excel
df_xls = pd.read_excel('../dataset_pandas.xlsx', usecols=['id','edad','IMC'])  
# Lee solo las columnas "id", "edad" e "IMC" de la hoja
print(df_xls)

# Leer todas las columnas y todas las filas exceptuando las tres últimas
df_xls = pd.read_excel('../dataset_pandas.xlsx', skipfooter=3)  
# Lee todo el Excel excepto las últimas 3 filas
print(df_xls)

# Revisar el tipo del DataFrame leído desde CSV
print(type(df_csv))  # Muestra el tipo de objeto (debería ser <class 'pandas.core.frame.DataFrame'>)

# Acceder a una columna específica
columna = df_csv['edad']  # Extrae solo la columna "edad" del DataFrame
print(columna)  # Imprime la columna

# Revisar el tipo de la columna
print(type(columna))  # Muestra el tipo de objeto (debería ser <class 'pandas.core.series.Series'>)

# Información general del DataFrame
df_csv.info()  # Muestra información del DataFrame: nº de filas, columnas, tipos de datos y valores nulos

# Dimensiones del DataFrame
df_csv.shape  # Devuelve una tupla con (número de filas, número de columnas)

# Nombre de las columnas
df_csv.columns  # Devuelve una lista con los nombres de todas las columnas

# Índices de las filas
df_csv.index  # Devuelve el rango de índices (ej. RangeIndex(start=0, stop=100, step=1))

# Convertir el DataFrame a un arreglo de NumPy
df_csv.to_numpy()  # Convierte los datos en un array de NumPy (útil para cálculos rápidos)

# Ver las primeras 10 filas
df_csv.head(10)  # Muestra las primeras 10 filas del DataFrame

# Estadísticas generales para columnas numéricas
df_csv.describe()  # Muestra estadísticas como media, desviación estándar, min, max, percentiles

# Estadísticas generales para columnas de tipo objeto (cadenas de texto)
df_csv.describe(include='object')  # Muestra conteos, valores únicos, moda y frecuencia

# Eliminar filas duplicadas
df_sin_dup = df_csv.drop_duplicates()  # Crea un nuevo DataFrame eliminando filas duplicadas
print("DataFrame con duplicados: " , df_csv.shape)  # Tamaño del DataFrame original
print("DataFrame sin duplicados: " , df_sin_dup.shape)  # Tamaño sin duplicados

# Eliminar filas con valores nulos (NaN)
df_sin_na  = df_csv.dropna()  # Crea un nuevo DataFrame eliminando filas con valores faltantes
print("DataFrame con duplicados: " , df_csv.shape)  # Tamaño del DataFrame original
print("DataFrame sin duplicados: " , df_sin_dup.shape)  # Tamaño del DataFrame sin duplicados
print("DataFrame sin duplicados ni NAN: " , df_sin_na.shape)  # Tamaño final sin duplicados ni valores nulos
dfe