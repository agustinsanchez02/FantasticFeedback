create database FF;
use FF;

create table Usuarios (
ID_Usuario int primary key,
Username nvarchar(50),
Mail nvarchar(100),
Contraseña nvarchar(20),
Nombre nvarchar(60),
Apellido nvarchar(60),
fechaNacimiento date,
Sexo nvarchar(12),
Nacionalidad nvarchar(50)) /* Hombre, Mujer o Desconocido*/

create table Juegos (
ID_Juego int primary key,
Título nvarchar(100),
TipoContenido nvarchar(30),
releaseDate date,
Plataforma nvarchar(50), /* Una publicación para cada plataforma */
Developer nvarchar(60),
Publisher nvarchar(60),
Score int) /* Promedio general de todas las reviews existentes */

create table Reviews (
ID_Review int primary key,
ID_Usuario int foreign key references Usuarios(ID_Usuario),
ID_Juego int foreign key references Juegos(ID_Juego),
Score int, /* La de un usuario */
Comentario nvarchar(200),
fechaPublicación date) 

create table Usuarios_Reviews (
ID_UsuarioReview int primary key,
ID_Usuario int foreign key references Usuarios(ID_Usuario),
ID_Review int foreign key references Reviews(ID_Review))

create table Juegos_Reviews (
ID_JuegoReview int primary key,
ID_Juego int foreign key references Juegos(ID_Juego),
ID_Review int foreign key references Reviews(ID_Review))

INSERT INTO Usuarios (ID_Usuario, Username, Mail, Contraseña, Nombre, Apellido, fechaNacimiento, Sexo, Nacionalidad) 
VALUES ('1', 'TitoSTG', 'ernestojmoretti@gmail.com', 'SuperTito13', 'Ernesto', 'Moretti', '06/10/2002', 'Maculino', 'Argentina')

INSERT INTO Usuarios 
VALUES ('2', 'Agusanchez', 'agusjcr2016@gmail.com', 'Agusanchh', 'Agustin', 'Sánchez', '15/04/2002', 'Masculino', 'Argentina')

select * from Usuarios

INSERT INTO Juegos 
VALUES ('1', 'Resident Evil 4', 'Juego Completo', '24/03/2023', 'PS4 PS5 XBOX SERES X/S PC', 'Capcom', 'Capcom', '94')


INSERT INTO Juegos 
VALUES ('2', 'Sonic Frontiers', 'Juego Completo', '18/10/2013', 'PS4 PS5 XBOX PC SWITCH', 'Sonic Team', 'SEGA', '40')

INSERT INTO Juegos 
VALUES ('3', 'Hogwarts Legacy', 'Juego Completo', '10/02/2023', 'PS4 PS5 XBOX PC SWITCH', ' Avalanche Software', ' Warner Bros. Games', '100')


select * from Juegos

INSERT INTO Reviews
Values ('1', '2', '3', '100', '"El mejor juego de magia de la vida!"', '20/02/2023')

INSERT INTO Reviews
Values ('2', '1', '1', '94', '"Excelente juego, me encanto!"', '25/05/2023')	

INSERT INTO Reviews
Values ('3', '2', '2', '47', '“Bueno juego, aunque esperaba más"', '19/10/2023')	

INSERT INTO Reviews
Values ('4', '2', '1', '93', '“Uno de los mejores remakes que he jugado en mi vida"', '30/03/2023')	

INSERT INTO Reviews
Values ('5', '1', '2', '72', '“No es un mal juego, lo disfruté. Pero es muy corto”', '25/10/2023')	

INSERT INTO Reviews
Values ('6', '1', '3', '72', '“Prefiero Sonic pero este juego es insuperable”', '12/04/2023')	

select * from Reviews

INSERT INTO Usuarios_Reviews
VALUES ('1', '2', '1')

INSERT INTO Usuarios_Reviews
VALUES ('2', '1', '2')

INSERT INTO Usuarios_Reviews
VALUES ('3', '2', '3')

INSERT INTO Usuarios_Reviews
VALUES ('4', '2', '4')

INSERT INTO Usuarios_Reviews
VALUES ('5', '1', '5')

INSERT INTO Usuarios_Reviews
VALUES ('6', '1', '6')

select * from Usuarios_Reviews

INSERT INTO Juegos_Reviews
VALUES ('1', '3', '1')

INSERT INTO Juegos_Reviews
VALUES ('2', '1', '2')

INSERT INTO Juegos_Reviews
VALUES ('3', '2', '3')

INSERT INTO Juegos_Reviews
VALUES ('4', '1', '4')

INSERT INTO Juegos_Reviews
VALUES ('5', '2', '5')

INSERT INTO Juegos_Reviews
VALUES ('6', '3', '6')

select * from Juegos_Reviews
