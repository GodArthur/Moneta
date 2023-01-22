create database moneta_db;
use moneta_db;

create table users(
user_id INT primary key,
first_name varchar(20),
last_name varchar(40),
email varchar(50),
date_of_birth date
);

create table transactions(
	transaction_id int primary key,
    total_spent decimal(10,2) not null,
    transaction_date date,
    company varchar(50),
    category int not null references categories(category_id),
    receipt_num int references receipts(receipt_num),
    user_id int not null references users(user_id)
);

create table categories (

	category_id int primary key,
    category_name varchar(60)
);

create table receipts (

receipt_num int primary key,
screenshot BLOB
);






