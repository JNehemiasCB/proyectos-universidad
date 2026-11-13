ventas <- c (10, 12, 11, 13, 12, 14, 16, 12, 14, 11, 10, 19, 8.5, 8, 9 ,13, 16, 18, 20, 22)
tv <- c(13, 14, 15, 17, 17.5, 13, 14.5, 9, 8, 9, 8, 10, 17, 18, 18.5, 19, 20, 20, 13, 14)
radio <- c(56, 55, 60 ,65, 69, 67, 68, 67, 97, 66, 65, 60, 70, 110, 75, 80, 85, 90, 56, 55)
periodicos <- c(40, 40, 42, 50, 40, 44,40, 44, 46, 46, 45, 110, 30, 50, 45, 40, 80, 90, 90 ,110)

cereales <- data.frame(ventas, tv, radio, periodicos)
cereales

plot(cereales$ventas, cereales$tv)

reg_lin <- lm (ventas ~ tv, data = cereales)
reg_lin

summary (reg_lin)
reg_lin2 <- lm(ventas ~ 0 + tv, datda = cereales)
reg_lin2

cor.test(cereales$ventas, cereales $tv)

reg_lin_mul <- lm(ventas ~ tv + radio, data = cereales)
reg_lin_mul

reg_lin_mul2 <- lm(ventas ~ tv + radio + periodicos, data = cereales)
reg_lin_mul2

summary(reg_lin_mul2)

