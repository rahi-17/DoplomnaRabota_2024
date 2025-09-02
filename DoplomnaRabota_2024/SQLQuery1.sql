create table admin1
(
id int primary key identity(1,1),
email varchar(max) null,
username varchar(max) null,
pssword varchar(max) null,
date_create date null
)
SELECT * FROM admin1
