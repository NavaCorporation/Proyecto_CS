CREATE TABLE Usuario (
    id_Usuario INT PRIMARY KEY IDENTITY(1,1),
    nombres VARCHAR(30) NOT NULL,
	apellidos VARCHAR(30) NOT NULL,
    username VARCHAR(15) UNIQUE NOT NULL,
	cedula VARCHAR (10) UNIQUE not null,
	sexo VARCHAR(15) NOT NULL CHECK (sexo IN ('Masculino', 'Femenino')),
	fecha_nacimiento DATE,
	estado VARCHAR(1) NOT NULL,
    mail VARCHAR(50) UNIQUE NOT NULL,
    perfil_usuario VARCHAR(15) NOT NULL CHECK (perfil_usuario IN ('administrador', 'proveedor', 'cliente')),
    contrasena VARCHAR(50) NOT NULL
);





