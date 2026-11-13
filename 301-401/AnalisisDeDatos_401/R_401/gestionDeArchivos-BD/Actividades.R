#Actividad1
library(DBI)
library(RMySQL)

drv2<-dbDriver("MySQL")
conect <- dbConnect(drv2, dbname = "world", username = "root", password = "201105", host = "localhost")
datos <- dbGetQuery(conect, "SELECT DISTINCT ID, Name FROM city ORDER BY ID ")
head(datos)

dbDisconnect(conect)
#dbUnloadDriver(drv2)

library(dplyr)
library(dbplyr)

conectarse <- dbConnect(drv2, dbname = "sakila", user = "root", password = "201105", host = "localhost")
peliculas <- tbl(conectarse, "film")
peliculas %>% filter(film_id > 200,  release_year == 2012) %>%  select(rental_duration, rating)

