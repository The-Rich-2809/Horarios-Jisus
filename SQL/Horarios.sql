Set Nocount on 
Go
Use master
Go
IF EXISTS (SELECT * FROM sysdatabases WHERE NAME='Horario')
		DROP DATABASE Horario
GO
Create DataBase Horario 
Go
Use Horario 
Go

CREATE TABLE Users
(IdUsuario INT PRIMARY KEY NOT NULL,
Usuario NVARCHAR (20) NOT NULL,
Contrasena  VARBINARY(20) NOT NULL,
Nivel_Usuario INT NOT NULL,
Nombre VARCHAR (20) NOT NULL,)
Go
Insert Into Users Values 
(0, 'Juan',HASHBYTES('SHA1',N'bonafont13'),1,'Juanito R.'),
(1,'Paco',HASHBYTES('SHA1',N'bonafont14'),0,'Francisco A.'),
(2, 'Maria', HASHBYTES('SHA1', N'contrasena1'), 1, 'Maria M.'),
(3, 'Ana', HASHBYTES('SHA1', N'contrasena2'), 0, 'Ana A.'),
(4, 'Carlos', HASHBYTES('SHA1', N'contrasena3'), 1, 'Carlos C.'),
(5, 'Luisa', HASHBYTES('SHA1', N'contrasena4'), 0, 'Luisa L.'),
(6, 'Pedro', HASHBYTES('SHA1', N'contrasena5'), 1, 'Pedro P.'),
(7, 'Isabel', HASHBYTES('SHA1', N'contrasena6'), 0, 'Isabel I.'),
(8, 'Miguel', HASHBYTES('SHA1', N'contrasena7'), 1, 'Miguel M.'),
(9, 'Laura', HASHBYTES('SHA1', N'contrasena8'), 0, 'Laura L.')
Go

Create Table Clases
(IdClases NVARCHAR (20) PRIMARY KEY  NOT NULL,
Semestre INT NOT NULL,
Turno NVARCHAR (10) NOT NULL,
NumGrupo INT NOT NULL,
Grupo NVARCHAR (5) NOT NULL,
Salon NVARCHAR (max) NOT NULL,
Materia NVARCHAR (max) NOT NULL,
Profesor NVARCHAR (50) NOT NULL,
LunesI NVARCHAR (5) NOT NULL,
LunesF NVARCHAR (5) NOT NULL,
MartesI NVARCHAR (5) NOT NULL,
MartesF NVARCHAR (5) NOT NULL,
MiercolesI NVARCHAR (5) NOT NULL,
MiercolesF NVARCHAR (5) NOT NULL,
JuevesI NVARCHAR (5) NOT NULL,
JuevesF NVARCHAR (5) NOT NULL,
ViernesI NVARCHAR (5) NOT NULL,
ViernesF NVARCHAR (5) NOT NULL)
Go
Insert Into Clases Values
('1IV1101','1','Vespertino','1','1IV1','Salon 12','ÁLGEBRA','JUAN JOSE BELTRAN CORONA','18:00','19:00','18:00','19:00','18:00','19:00','18:00','19:00','19:00','20:00'),
('3IV1301','3','Vespertino','1','3IV1','Salon 11','GEOMETRIA ANALITICA','HECTOR MANUEL MENDOZA QUIROZ','','','21:00','22:00','21:00','22:00','21:00','22:00','21:00','22:00'),
('5IV11501','5','Vespertino','11','5IV11','Salon 10','CALCULO INTEGRAL','JESUS GUTIERREZ MORAN','','','20:00','21:00','16:00','17:00','19:00','21:00','',''),
('1IV1102','1','Vespertino','1','1IV1','Salon 15','ÁLGEBRA LINEAL','MARIA ELENA RAMIREZ GARCIA','18:30','19:30','18:30','19:30','18:30','19:30','18:30','19:30','19:30','20:30'),
('2IV2201','2','Vespertino','2','2IV2','Salon 14','GEOMETRIA DESCRIPTIVA','ANA LAURA TORRES MARTINEZ','19:00','20:00','19:00','20:00','19:00','20:00','19:00','20:00','20:00','21:00'),
('3IV3301','3','Vespertino','3','3IV3','Salon 13','ECUACIONES DIFERENCIALES','CARLOS ALBERTO CASTILLO MORALES','20:30','21:30','20:30','21:30','20:30','21:30','20:30','21:30','21:30','22:30'),
('4IV4401','4','Vespertino','4','4IV4','Salon 12','PROBABILIDAD Y ESTADISTICA','LAURA PATRICIA GOMEZ GARCIA','21:00','22:00','21:00','22:00','21:00','22:00','21:00','22:00','22:00','23:00'),
('5IV5501','5','Vespertino','5','5IV5','Salon 21','PROGRAMACION ESTRUCTURADA','JOSE LUIS PEREZ HERNANDEZ','','','18:00','20:00','17:00','19:00','18:00','20:00','19:00','21:00'),
('6IV6601','6','Vespertino','6','6IV6','Salon 20','BASE DE DATOS','SOFIA MARTINEZ RAMIREZ','19:30','20:30','19:30','20:30','19:30','20:30','19:30','20:30','20:30','21:30')
Go

Create Table Profesores
(IdProfe INT PRIMARY KEY NOT NULL,
Nombre NVARCHAR (20) NOT NULL,
PApellido NVARCHAR (15) NOT NULL,
SApellido NVARCHAR (15) NOT NULL,
Semestre INT NOT NULL,
Turno NVARCHAR (10) NOT NULL,
Clases INT NOT NULL)
Go
Insert Into Profesores Values
(101,'JUAN JOSE','BELTRAN','CORONA',1,'Vespertino',1),
(301,'HECTOR MANUEL','MENDOZA','QUIROZ',3,'Vespertino',1),
(501,'JESUS','GUTIERREZ','MORAN',5,'Vespertino',1),
(102, 'MARIA ELENA', 'RAMIREZ', 'GARCIA', 1, 'Vespertino', 1),
(201, 'ANA LAURA', 'TORRES', 'MARTINEZ', 2, 'Vespertino', 1),
(302, 'CARLOS ALBERTO', 'CASTILLO', 'MORALES', 3, 'Vespertino', 1),
(401, 'LAURA PATRICIA', 'GOMEZ', 'GARCIA', 4, 'Vespertino', 1),
(502, 'JOSE LUIS', 'PEREZ', 'HERNANDEZ', 5, 'Vespertino', 1),
(601, 'SOFIA', 'MARTINEZ', 'RAMIREZ', 6, 'Vespertino', 1)
Go

Create Table Materias
(IdMateria INT PRIMARY KEY NOT NULL,
Nombre NVARCHAR (50) NOT NULL,
Semestre INT NOT NULL,
Clases INT NOT NULL)
Go
Insert Into Materias Values
(101,'ÁLGEBRA',1,1),
(301,'GEOMETRIA ANALITICA',3,1),
(501,'CALCULO INTEGRAL',5,1),
(102, 'ÁLGEBRA LINEAL', 1, 1),
(201, 'GEOMETRIA DESCRIPTIVA', 2, 1),
(302, 'ECUACIONES DIFERENCIALES', 3, 1),
(401, 'PROBABILIDAD Y ESTADISTICA', 4, 1),
(502, 'PROGRAMACION ESTRUCTURADA', 5, 1),
(601, 'BASE DE DATOS', 6, 1)
Go

Create Table Reportes
(IdReporte INT PRIMARY KEY NOT NULL,
Grupo NVARCHAR (5) NOT NULL,
Turno NVARCHAR (10) NOT NULL,
Materia NVARCHAR (50) NOT NULL,
DiaReporte Date NOT NULL,
Reporte TEXT NOT NULL)
Go
Insert Into Reportes Values
(1,'1IV1','Vespertino','ÁLGEBRA','2021/03/04','El maestro no se presento'),
(7, '1IV1', 'Vespertino', 'ÁLGEBRA LINEAL', '2024-01-20', 'Informe del grupo 1IV1 para la materia de Álgebra Lineal.'),
(2, '2IV2', 'Vespertino', 'GEOMETRIA DESCRIPTIVA', '2024-01-21', 'Informe del grupo 2IV2 sobre Geometría Descriptiva.'),
(3, '3IV3', 'Vespertino', 'ECUACIONES DIFERENCIALES', '2024-01-22', 'Informe del grupo 3IV3 para ECUACIONES DIFERENCIALES.'),
(4, '4IV4', 'Vespertino', 'PROBABILIDAD Y ESTADISTICA', '2024-01-23', 'PROBABILIDAD Y ESTADISTICA: Grupo 4IV4 presenta su informe.'),
(5, '5IV5', 'Vespertino', 'PROGRAMACION ESTRUCTURADA', '2024-01-24', 'Informe de PROGRAMACION ESTRUCTURADA Descriptiva del grupo 5IV5.'),
(6, '6IV6', 'Vespertino', 'BASE DE DATOS', '2024-01-25', 'Informe sobre BASE DE DATOS del grupo 6IV6.')
Go