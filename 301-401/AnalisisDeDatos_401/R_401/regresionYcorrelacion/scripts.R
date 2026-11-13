edad <- c(56, 42, 72, 36, 63, 47, 55, 47, 38, 42)
presion <- c(148, 126, 159, 118, 149, 130, 151, 142, 114, 141)

plot(presion, edad)
reg_lin <- lm(edad ~ presion)
reg_lin

summary(reg_lin)

plot(presion, edad)
abline(reg_lin)
plot(reg_lin)

ks.test(reg_lin$residuals, "pnorm")

install.packages("lmtest")
library(lmtest)

dwtest(edad ~ presion)

#Actividad 8

gastos <- c (1000, 580, 520, 500, 600, 550, 400)
ingresos <- c (50000, 2500, 2000, 1900, 3000, 4000, 2000)
tamaño <- c (7, 4, 3, 3, 6, 5, 2)
hijosU <- c (3, 1, 1, 0, 1, 2, 0)

GastoAlim <- data.frame (gastos, ingresos, tamaño, hijosU)
GastoAlim

reg_lin_mul <- lm ( gastos ~ ingresos + tamaño + hijosU)
summary(reg_lin_mul)

#Actividad 9
cor(gastos, ingresos)
cor(GastoAlim)
cor.test(gastos, ingresos)

#Actividad 10 
lm (formula = gastos ~ ingresos + tamaño ^ 2 )
