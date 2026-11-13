install.packages("DBI")
install.packages("RMySQL")
library(DBI)
library(RMySQL)

drv<-dbDriver("MySQL")
con <- dbConnect(drv, dbname = "world", username = "root", password = "201105", host = "localhost")
datos <- dbGetQuery(con, "SELECT DISTINCT Name, IndepYear FROM country, countrylanguage WHERE Language = 'Spanish' ")
head(datos)

res <- dbSendQuery(con, "SELECT * FROM country")
while (!dbHasCompleted(res))
{
  #obetener los siguientes 50 registros en un marco de datos
  algunosDatos <- fetch(res, n = 50)
  # llamar a alguna funcion que maneje el fragmento actual 
  View(algunosDatos)
}

dbDisconnect(con)
#dbUnloadDriver(drv)
