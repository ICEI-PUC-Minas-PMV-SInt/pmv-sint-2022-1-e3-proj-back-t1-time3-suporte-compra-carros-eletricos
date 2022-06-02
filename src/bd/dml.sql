/* Comandos de inserção*/
INSERT INTO 
usuarios(id, nome, sobrenome, email, senha, status, data_criacao) 
VALUES (1, "Pedro", "Silva", "pedro.silva@email.com", 123123, true, "2022-06-02 00:00:00");

INSERT INTO 
carros_combustao(id, modelo, motor, valor, media_consumo, imagem, data_criacao, id_usuario) 
VALUES (2 , "Palio", 155, 200000, 13, "https://www.istoedinheiro.com.br/wp-content/uploads/sites/17/2018/02/palio.jpg", "2022-06-02 00:00:00", 1);

INSERT INTO 
carros_eletricos(id, modelo, motor, valor, capacidade_bateria, autonomia, eficiencia, imagem, data_criacao, id_usuario) 
VALUES (2, "JAC e-JS1", 156, 260000, 200, 320, 53, "https://motorshow.com.br/wp-content/uploads/sites/2/2021/09/05-jac-e-js1.jpg", "2022-06-02 00:00:00", 1);

/* Comandos de atualização*/
UPDATE carros_combustao SET modelo = "Corsa" WHERE id = 1;
UPDATE carros_eletricos SET motor = "250" WHERE id = 1;
UPDATE usuarios SET sobrenome = "Marques" WHERE id = 1;

/* Comandos de deleção*/
DELETE FROM carros_combustao WHERE id = 1;
DELETE FROM carros_eletricos WHERE id = 1;
DELETE FROM usuarios WHERE id = 2;

/* Comandos de seleção*/
SELECT * FROM carros_combustao;
SELECT * FROM carros_eletricos;
SELECT * FROM usuarios;