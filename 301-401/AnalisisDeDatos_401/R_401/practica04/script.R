install.packages("repmis")
library(repmis)
source_data("https://github.com/hllinas/DatosPublicos/blob/main/Estudiantes.Rdata?raw=false")
datos_estud <- Estudiantes
datos_estud
View(datos_estud)
head(datos_estud)
head(datos_estud, 3)
tail(datos_estud)
tail(datos_estud, 2)

str(datos_estud)
class(datos_estud)
names(datos_estud)
help(datos_estud)
??datos_estud

dim(datos_estud)
length(datos_estud)
ncol(datos_estud)
nrow(datos_estud)

muestra1 <- datos_estud[1:10,2:7]
muestra1
muestra1[3,2]
muestra1[,2]
muestra1[3,]
muestra1[-5,]
muestra1[,-2]
muestra1[,2:5]
muestra1 [,c(2,5)]
muestra1[c(1,5), c(2,4)]

muestra2 <- subset(muestra1, select = c(ID, Edad, Fuma))
muestra3 <- subset(muestra1, Edad >=20, select = -c(ID, Fuma))
muestra4 <- subset(muestra1, Edad <= 18 | Edad > 21, select = -c(ID, Fuma))
muestra5 <- subset(muestra1, Edad <= 18 & Edad <= 21, select = -c(ID, Fuma))
muestra6a <- subset(muestra1, muestra1$Fuma=="Si")
muestra6b <- subset(muestra1, muestra1$Fuma!="No")
muestra6c <- subset(muestra1, muestra1$SexoNum=="0" & muestra1$Edad > 21)

filas <- nrow(muestra1)
n <- 2
i <- sample(1:filas, n, replace = FALSE)
muestra7 <-muestra1[i,]
muestra7
filas <- nrow(muestra1)
n<-2
i <- sample(1:filas, n, replace = FALSE)
muestra8 <- muestra1[i,]
muestra8

set.seed(1)
f <- nrow((muestra1))
n<-2
i <- sample(1:f, n, replace = FALSE)
muestra9 <- muestra1[i, 4:6]
muestra9

muestra10a <- filter(muestra1, muestra1$Edad >=20)
muestra10b <- filter(muestra1, muestra1$Edad>=20 & muestra1$SexoNum < 1)
muestra10c <- filter(muestra1[,2:4], muestra1$Edad >= 20 & muestra1$Sexo == "Femenino")
muestra10d <- filter(muestra1[,2:4], muestra1$Edad >= 20 | muestra1$Sexo == "Femenino")
muestra10e <- filter(muestra1, muestra1$Edad >= 20 & muestra1$Sexo != "Masculino")
muestra10f <- filter(muestra1, muestra1$Edad >= 20 | muestra1$Sexo == "Femenino")
muestra10g <- filter(muestra1, muestra1$Edad < 20 | muestra1$Estatura != "Alta")
muestra10h <- filter(muestra1, muestra1$Edad >= 18 & muestra1$Estatura %in% c("Baja", "Media", "Gigante"))
muestra10i <- filter(muestra1, muestra1$SexoNum != 1 & muestra1$Fuma %in% c("Si", "Enfermo", "Delicado"))

install.packages("dplyr")
library(dplyr)
muestra1 %>% filter(Sexo == "Feminino") -> Mujeres
Mujeres
Mujeres %>% names
muestra11a <- muestra1 %>% filter(Edad > 17)
muestra11a
muestra11b <- muestra1 %>% filter(SexoNum == "1")
muestra11b
muestra11c <- muestra1 %>% filter(Edad >= 20)
muestra11c
muestra11d <- muestra1 %>% filter(Edad >= 20 & SexoNum < 1)
muestra11d
muestra11e <- muestra1[,2:4] %>% filter(Edad >= 20 & Sexo == "Femenino")
muestra11e
muestra11k <- muestra1[,2:4] %>% filter(Edad >= 20 | Sexo == "Femenino")
muestra11k
muestra11f <- muestra1 %>% filter(Edad >= 20 & Sexo != "Masculino")
muestra11f
muestra11g <- muestra1 %>% filter(Edad >= 20 | Sexo == "Femenino")
muestra11g
muestra11h <- muestra1 %>% filter(Edad < 20 | Estatura != "Alta")
muestra11h
muestra11i <- muestra1 %>% filter(Edad >= 18, Estatura %in% c("Baja", "Media", "Gigante"))
muestra11i
muestra11j <- muestra1 %>% filter(SexoNum != 1, Fuma %in% c("Sí", "Enfermo", "Delicado"))
muestra11j

