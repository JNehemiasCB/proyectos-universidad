#América Latina
latam <- data.frame(
  pais = c("Argentina", "Bolivia", "Chile", "Colombia", "Costa Rica", "R. Dominicana", "Ecuador", "México",
           "Panamá", "Perú", "Uruguay", "Venezuela"),
  cal_dia = c(3170, 2060, 2720, 2280, 2610, 2080, 1850, 2620, 2420, 2300, 3020, 2490),
  region = "latam"
)

#Europa
eu <- data.frame(
  pais = c("Alemania Occidental", "Alemania Oriental", "Dinamarca", "España", "Francia", "Inglaterra", "Italia",
           "Polonia", "Portugal", "Suecia", "Suiza", "Yugoslavia"),
  cal_dia = c(2960, 3040, 3180, 2680, 3180, 3180, 2940, 3140, 2930, 2880, 2990, 3200),
  region = "Europa"
)

# Unir ambos data frames
CalPorDia <- rbind(latam, eu)

# Ver el resultado
print(CalPorDia)
