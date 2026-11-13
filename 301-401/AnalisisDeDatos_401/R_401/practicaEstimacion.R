nivcloro <- c(2.2,1.9,1.7,1.6,1.7,1.8,1.7,1.9,2,2)
nivcloro
mean(nivcloro)

ventasA <- c(1320,1495,990,1250,12900,1900,1500,1100,1250,1100,1930)
ventasB <- c(1110,1405,985,1290,1300,1705,1200,1105,1150,1210,NA)
datos <- as.data.frame(cbind(ventasA, ventasB))
datos
attach(datos)
ventasA
ventasB

mean(ventasA, na.rm = T); mean(ventasB, na.rm = T)

var(nivcloro)
sd(nivcloro)
var(ventasA); var(ventasB, na.rm = T)
sd(ventasA); sd(ventasB, na.rm = T) 

t.test(nivcloro, conf.level = 0.99)$conf

round(c(9*var(nivcloro)/qchisq(0.995, 9),9*var(nivcloro)/qchisq(0.005,9)),4)

IC.para.la.varianza<-function (x,alfa)
  +round(c((length(x)-1)*var(x)/qchisq (1-alfa/2, length(x)-1),
           +(length(x)-1)*var(x)/qchisq (alfa/2, length(x)-1)),4)
IC.para.la.varianza (x=nivcloro, alfa=0.01)
IC.para.la.varianza(nivcloro,0.05)

var.test(ventasA,ventasB)$conf

t.test(ventasA,ventasB,var.equal = F)$conf
12/150
prop.test(12,150)$conf

valores <- rnorm(20,10,2)
t.test(valores)$conf

IC.varianza <- c(9*var(valores)/qchisq(0.975,9),9*var(valores)/qchisq(0.025,9))
IC.varianza

muestra1 <- rnorm(50,0,1)
muestra2 <- rnorm(50,0,5)
a <- t.test(muestra1)$conf
b <- t.test(muestra2)$conf
a
b

