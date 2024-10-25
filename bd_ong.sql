CREATE DATABASE bdong;

USE bdOng;


CREATE TABLE responsavel (
    id INT AUTO_INCREMENT,
    nome VARCHAR(100),
    cpf VARCHAR(30),
    rg VARCHAR(30),
    telefone VARCHAR(20),
    email VARCHAR(50),  
    data_nascimento DATE,
    endereco VARCHAR(50), 
    estado_civil VARCHAR(30),
    cidade VARCHAR(50),
    estado VARCHAR(50),
    numero INT,
    cep VARCHAR(40),
    complemento VARCHAR(50),
    CONSTRAINT id_responsavel PRIMARY KEY (id)
);

CREATE TABLE escola (
    id INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(20) NOT NULL,
    telefone VARCHAR(20) NOT NULL,
    CONSTRAINT id_escola PRIMARY KEY (id)
);

CREATE TABLE estoque (
    id INT AUTO_INCREMENT,
    nome_produto VARCHAR(50),
    quantidade INT,
    descricao VARCHAR(50) NOT NULL,
    vencimento DATE NOT NULL,
    tipo_item VARCHAR(30),
    data_entrada DATE,
    data_saida DATE,
    CONSTRAINT id_estoque PRIMARY KEY (id)
);


CREATE TABLE crianca (
    id INT AUTO_INCREMENT,
    nome VARCHAR(100),
    data_nascimento DATE,
    tamanho VARCHAR(20),
    serie VARCHAR(10) NOT NULL,
    frequencia INT NOT NULL,
    media_notas INT NOT NULL,
    id_responsavel INT,
    id_escola INT,
    CONSTRAINT id_crianca PRIMARY KEY (id),
    CONSTRAINT fk_id_responsavel FOREIGN KEY (id_responsavel) REFERENCES responsavel (id), -- Corrigido para id
    CONSTRAINT fk_id_escola FOREIGN KEY (id_escola) REFERENCES escola (id)  -- Corrigido para id
);


CREATE TABLE doacao (
    id INT AUTO_INCREMENT,
    nome_produto VARCHAR(50),
    quantidade INT,
    data_doacao DATE,
    tipo_doacao VARCHAR(30),
    id_estoque INT,
    id_crianca INT,
    CONSTRAINT id_doacao PRIMARY KEY (id),
    CONSTRAINT fk_id_estoque FOREIGN KEY (id_estoque) REFERENCES estoque (id),
    CONSTRAINT fk_id_crianca FOREIGN KEY (id_crianca) REFERENCES crianca (id)
);


CREATE TABLE distribuicao_marmita (
    id INT AUTO_INCREMENT,
    data_entrega DATE,
    quantidade INT,
    id_estoque INT,
    id_responsavel INT,
    CONSTRAINT id_marmita PRIMARY KEY (id),
    CONSTRAINT fk_id_estoque_distr FOREIGN KEY (id_estoque) REFERENCES estoque (id),
	CONSTRAINT fk_id_responsavel_distr FOREIGN KEY (id_responsavel) REFERENCES responsavel (id)
);

CREATE TABLE evento (
id INT AUTO_INCREMENT,
nome_evento VARCHAR(50),
data_evento DATE,
descricao VARCHAR(50),
CONSTRAINT id_evento PRIMARY KEY (id)
);

select * from responsavel;
