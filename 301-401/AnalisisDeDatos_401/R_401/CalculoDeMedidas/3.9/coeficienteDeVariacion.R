coef_var <- function(x, na.rm = FALSE) {
  sd(x, na.rm = na.rm) / mean(x, na.rm = na.rm)
}

cvLatam <- coef_var(latam$cal_dia)
cvEu <- coef_var(eu$cal_dia)

cvLatam
cvEu
