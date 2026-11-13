library(readxl)
library(dplyr)
costoPromedio <- "costo-total-promedio.xlsx"
h202003 <- read_excel(costoPromedio, sheet = 1)
h202003df <- as.data.frame(h202003)
View(h202003df)
head(h202003df, 3)
tail(h202003df, 3)
str(h202003df)
dim(h202003df)
muestra1 <- filter(h202003df, h202003$estado == "Chihuahua"); muestra1
muestra2 <- filter(h202003df, h202003$díasDeTratamientoDelPaciente == 2); muestra2
muestra3 <- filter(h202003df, h202003df$costoDelTratamiento >= 100000); muestra3
muestra4 <- filter(h202003df, h202003df$estado == "Estado de México" & h202003df$costoDelTratamiento < 100000); muestra4
muestra5 <- filter(h202003df, h202003df$díasDeTratamientoDelPaciente > 10); muestra5

