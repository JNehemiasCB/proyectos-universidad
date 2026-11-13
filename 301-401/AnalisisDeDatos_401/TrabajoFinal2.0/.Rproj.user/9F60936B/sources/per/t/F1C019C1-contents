library(readxl)
library(tidyverse)

# 1. Leer el archivo especificando el rango correcto (ajusta según tu archivo)
datos_brutos <- read_excel(
  "Población en situación de pobreza por entidad federativa según grado, 2018, 2020 y 2022.xlsx",
  range = "A3:J34"  # Ajusta este rango según tu archivo real
)

# 2. Renombrar columnas manualmente
colnames(datos_brutos) <- c(
  "Entidad", 
  "Total_2018", "Moderada_2018", "Extrema_2018",
  "Total_2020", "Moderada_2020", "Extrema_2020",
  "Total_2022", "Moderada_2022", "Extrema_2022"
)

# 3. Limpieza de datos
datos_brutos <- datos_brutos %>% 
  filter(!is.na(Entidad), !Entidad %in% c("Estados Unidos Mexicanos", "Total Nacional"))

# 4. Pivotear a formato largo (ignorar advertencia)
datos_largos <- datos_brutos %>%
  pivot_longer(
    cols = -Entidad,
    names_to = c("Tipo", "Año"),
    names_sep = "_",
    values_to = "Valor"
  ) %>%
  mutate(Año = as.integer(Año))

# 5. Filtrar solo pobreza extrema
pobreza_extrema <- datos_largos %>% 
  filter(Tipo == "Extrema")

# 6. Comparación 2018 vs 2022 (versión robusta)
pobreza_comparacion <- pobreza_extrema %>%
  filter(Año %in% c(2018, 2022)) %>%
  pivot_wider(
    names_from = Año,
    values_from = Valor,
    names_prefix = "valor_"
  ) %>%
  mutate(
    Diferencia = valor_2022 - valor_2018,
    Porcentaje_Cambio = round((Diferencia / valor_2018) * 100, 2)
  )

# 7. Ver resultados
print(pobreza_comparacion)

# 8. Gráfico de diferencias
ggplot(pobreza_comparacion, aes(x = reorder(Entidad, Diferencia), y = Diferencia, 
                                fill = ifelse(Diferencia < 0, "Reducción", "Aumento"))) +
  geom_col() +
  coord_flip() +
  scale_fill_manual(values = c("Aumento" = "salmon", "Reducción" = "steelblue")) +
  labs(
    title = "Cambio en pobreza extrema por entidad federativa (2018-2022)",
    x = "",
    y = "Diferencia (miles de personas)",
    fill = "Tendencia"
  ) +
  theme_minimal() +
  theme(legend.position = "top") +
  geom_hline(yintercept = 0, linetype = "solid", color = "black") +
  scale_y_continuous(breaks = seq(-200, 200, by = 50))  # Escala más detallada












library(ggplot2)
ggplot(pobreza_extrema, aes(x = as.factor(Año), y = Valor)) +
  geom_boxplot(fill = "#F8766D", alpha = 0.7) +
  labs(title = "Distribución nacional de pobreza extrema",
       x = "Año", y = "Personas (miles)") +
  theme_minimal()







ggplot(pobreza_extrema, aes(x = as.factor(Año), y = Valor)) +
  geom_violin(fill = "lightblue", trim = FALSE) +
  geom_jitter(width = 0.1, alpha = 0.5, color = "darkblue") +
  labs(title = "Densidad y dispersión por año", x = "Año") +
  theme_classic()









pobreza_extrema %>%
  group_by(Año) %>%
  mutate(Media_Nacional = mean(Valor),
         Desviacion = Valor - Media_Nacional) %>%
  ggplot(aes(x = reorder(Entidad, Desviacion), y = Desviacion, fill = Desviacion > 0)) +
  geom_col() +
  facet_wrap(~Año, scales = "free_y") +
  coord_flip() +
  scale_fill_manual(values = c("blue", "red")) +
  labs(title = "Desviación respecto a la media nacional", x = "") +
  theme(legend.position = "none")








pobreza_extrema %>%
  group_by(Entidad) %>%
  mutate(Cambio = (Valor - first(Valor)) / first(Valor) * 100) %>%
  ggplot(aes(x = as.factor(Año), y = reorder(Entidad, Cambio), fill = Cambio)) +
  geom_tile(color = "white") +
  scale_fill_gradient2(low = "blue", mid = "white", high = "red", midpoint = 0) +
  labs(title = "Cambio porcentual (2018-2022)", x = "Año", y = "") +
  theme_minimal()








library(ggradar)
estados_clave <- c("Chiapas", "Guerrero", "Nuevo León", "Ciudad de México")

pobreza_extrema %>%
  filter(Entidad %in% estados_clave) %>%
  select(Entidad, Año, Valor) %>%
  pivot_wider(names_from = Año, values_from = Valor) %>%
  ggradar(axis.label.size = 3,
          values.radar = c("Min", "Medio", "Max"),
          legend.position = "bottom")











library(ggExtra)
datos_wide <- pobreza_extrema %>%
  pivot_wider(names_from = Año, values_from = Valor, names_prefix = "Año_")

p <- ggplot(datos_wide, aes(x = Año_2018, y = Año_2022)) +
  geom_point(aes(color = Año_2022 - Año_2018), size = 3) +
  geom_abline(slope = 1, linetype = "dashed") +
  scale_color_gradient2(low = "blue", high = "red", mid = "gray") +
  labs(title = "Comparación directa 2018 vs 2022", color = "Diferencia")

ggMarginal(p, type = "histogram", fill = "skyblue")
