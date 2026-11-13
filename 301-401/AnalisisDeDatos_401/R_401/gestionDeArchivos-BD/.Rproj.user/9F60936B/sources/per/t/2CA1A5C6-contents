library(DBI)
library(RMySQL)
install.packages("dplyr")
install.packages("dbplyr")
library(dplyr)
library(dbplyr)

drv3 <- dbDriver("MySQL")
conectar <- dbConnect(drv3, dbname = "sakila", user = "root", password = "201105", host = "localhost")
peliculas <- tbl(conectar, "film")
peliculas %>% filter(film_id > 274, release_year == 2006) %>% select(special_features, last_update)

dbDisconnect(conectar)
#dbUnloadDriver(drv3)

