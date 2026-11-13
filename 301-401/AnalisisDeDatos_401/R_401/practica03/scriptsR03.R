  #Ejemplo1
  A <- c("Masculino", "Femenino", "Masculino",
         "Masculino", "Femenino", "Masculino",
         "Femenino", "Masculino", "Masculino",
         "Femenino")
  B <- c(0,1,1,0,1,1,0,1,0,0)
  df <- data.frame(Genero = A, Binario = B);df
  #Ejemplo2
  datos <- data.frame(Estrato = c(4,3,1,6), Año = c(2000, 1999, 1969,1970), Puntaje = c(3.5, 4.3, 2.2, 3.8), Sexo = c("M", "M", "F", "M"));datos
  #Ejemplo3
  A <- 1:5
  B <- c("a", "b", "c", "d", "e") 
  #Ejemplo4
  PorFila <- rbind(A,B);PorFila
  PorColumna <- cbind(A,B);PorColumna
  #Ejemplo5
  PorFila <- as.data.frame(PorFila);PorFila
  PorColumna <- as.data.frame(PorColumna);PorColumna
  #Ejemplo6
  A <- c("Masculino", "Femenino", "Masculino", "Masculino",
         "Femenino", "Masculino", "Femenino", "Masculino")
  B <- c("Alemania", "Alemania", "Francia", "Colombia", "Colombia", "Colombia", "Francia", "Colombia")
  C <- c(4,5,8,6,10,11,4,7)
  df <- data.frame(Genero = A, Paises = B, Total = C);df
  #Ejemplo7
  by(df[,3],list(df$Genero), summary)
  #Elemplo8
  by(df[,3],list(df$Genero), boxplot)
  #Ejemplo9
  Resultado1 <- aggregate(df[,3], by=list(df$Genero), median)
  names(Resultado1)[1] = "Genero"
  names(Resultado1)[2] = "Mediana"
  Resultado1
  #Ejemplo10
  Resultado2 <- aggregate(df[,3], by=list(df$Genero, df$Paises), sum)
  names(Resultado2)[1] = "Genero"
  names(Resultado2)[2] = "Paises"
  names(Resultado2)[3] = "Suma"
  Resultado2
  Genero
  attach(df)
  Genero
  detach(df)
  Genero
  set.seed(61)
  empleado_id <- 1:10
  empleado_nombre <- c("Andrew", "Susan", "John", "Joe", "Jack", "Jacob", "Mary", "Kate", "Jacqueline", "Ivy")
  empleado_salario <- round (rnorm(10, mean = 1500, sd = 200))
  empleado_edad <- round (rnorm(10, mean = 50, sd = 8))
  empleado_puesto <- c("CTO", "CFO", "Administrativo", rep("Técnico", 7))
  
  df_1 <- data.frame(id = empleado_id [1:8], nombre = empleado_nombre [1:8], salario_mensual =  empleado_salario [1:8])
                   
  df_2<- data.frame(id = empleado_id [-5], nombre = empleado_nombre [-5],edad = empleado_edad [-5],position = empleado_puesto [-5])
                    
                    
  df_1
  df_2
  
  #inner join
  merge(x = df_1, y = df_2)
  merge(x = df_1, y = df_2, by = c("id", "nombre"))
  
  #left join
  merge(x = df_1, y = df_2, all.x = TRUE)
  
  #right join
  merge(x = df_1, y = df_2, all.y = TRUE)
  
  #outer join
  merge(x = df_1, y = df_2, all = TRUE)
   
  #cross join 
  fusionada <- merge(x = df_1, y = df_2, by = NULL)
  head(fusionada)
  
  #Data Frames de ejemplo
  df1 <- data.frame(var = c("uno", "dos", "tres", "cuatro", "cinco"), datos = c(1,5,1,6,8))
rownames(df1) <- c("A", "B", "C", "D", "E")
df1
df2 <- data.frame(var = c("tres", "uno", "ocho", "dos", "nueve"), datos = c(1,5,1,6,8))
rownames(df2) <- c("E", "A", "B", "D", "C")
df2

merge(df1, df2, by = 0, all = TRUE)
merge(df1, df2, by = "row.names", all = TRUE)

x <- data.frame(id = 1:4, año = 1995:1998)
x

y <- data.frame(id = c(4,1,3,2), año = c(1998, 1995, 1997, 1996), edad = c(22,25,23,24))
y

z <- data.frame(id = c(1,2,3), año = 1995:1997, salario = c(1000, 1200, 1599))
z

merge(x, merge(y,z))
merge(x, merge(y , z, all.y = TRUE, all.z = TRUE))

Reduce(function(x, y)merge(x,y), list(x,y,z))

