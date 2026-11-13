install.packages("readxl")
library("readxl")
datosEstud <- read_excel("3200 Estudiantes.xlsx")

#Ejemplo 1(tabla de frecuencias para una sola variable categorica)

str(datosEstud$Sexo)
sexFactor <- as.factor(datosEstud$Sexo)#Definir y convertir en factor
sexFactor
sexTabla <- table(sexFactor);sexTabla # Calcular tabla de frecuencias
class(sexTabla)

#Ejemplo 2(Convertir tabla en dataframe)

sexDF <- as.data.frame(sexTabla); sexDF # convirtiendo a data frame

#Ejemplo 3 (tabla de frecuencias relativas con prop.table)

sexFrecRel <- prop.table(sexTabla)# calcular frecuencias relativas 
sexFrecRelDF <- as.data.frame(sexFrecRel); sexFrecRelDF # convertir a data frame

#Ejemplo 4(unir frecuencias y frecuencias relativas)

tabla1 <- data.frame(sexDF, round(sexFrecRelDF[,2]*100, 2))
colnames(tabla1) <- c("Sexo", "Frecuencia", "Frecuencia relativa (%)")#editar nombres
tabla1

#Ejemplo5

varSexo <- as.factor(datosEstud$Sexo)
varFuma <- as.factor(datosEstud$Fuma)
tabla2 <- xtabs(~ varSexo + varFuma, data = datosEstud); tabla2

#Ejemplo 6(la funcion addmargins)

tabla3 <- addmargins(tabla2); tabla3
colnames(tabla3)[3] <- c("totalSex")
rownames(tabla3)[3] <- c("totalFum")
tabla3

tabla4 <- as.data.frame(tabla3); tabla4

#Ejemplo7(tabla cruzada  con ftable)
sex_factor <- as.factor(datosEstud$Sexo)
fuma_factor <- as.factor(datosEstud$Fuma)
colegio_factor <- as.factor(datosEstud$Colegio)
tabla5 <- xtabs(~ sex_factor + fuma_factor + colegio_factor, data = datosEstud); tabla5
tabla6 <- ftable(tabla5); tabla6

#Exportando tablas de r  a excel
install.packages("openxlsx")
library(openxlsx)
path <- "C:/Users/nehem/OneDrive/Documentos/AnalisisDeDatos_401/R_401/practica05"
write.xlsx(tabla1, path, sheetName = "Hoja1")

path <- "C:/Users/nehem/OneDrive/Documentos/AnalisisDeDatos_401/R_401/practica05"
lista <- list("Hoja1" = tabla1, "Hoja2" = tabla2, "Hoja3" = tabla4, "Hoja4" = tabla6 )
write.xlsx(lista, path)
