CREATE TABLE Usuarios(
	id INT PRIMARY KEY,
	nome VARCHAR(20) NOT NULL,
    	sobrenome VARCHAR(150) NOT NULL,
    	email VARCHAR(200) NOT NULL,
    	senha TEXT NOT NULL,
    	status BOOLEAN,
    	data_criacao DATETIME
);

CREATE TABLE carros_combustao(
	id INT PRIMARY KEY,
    	modelo VARCHAR(100),
    	motor INT,
    	valor DECIMAL,
    	media_consumo DECIMAL,
    	imagem TEXT,
    	data_criacao DATETIME,
    	id_usuario INT,
    
    	CONSTRAINT FK_carros_combustao_usuarios FOREIGN KEY (id_usuario) REFERENCES Usuarios(id)
    
);

CREATE TABLE carros_eletricos(
	id INT PRIMARY KEY,
    	modelo VARCHAR(100),
    	motor INT,
    	valor DECIMAL,
    	capacidade_bateria DECIMAL,
	autonomia DECIMAL,
    	eficiencia DECIMAL,
    	imagem TEXT,
    	data_criacao DATETIME,
    	id_usuario INT,
    
	CONSTRAINT FK_carros_eletricos_usuarios FOREIGN KEY (id_usuario) REFERENCES Usuarios(id)
);
