SET IDENTITY_INSERT Tiendas ON;
insert into Tiendas (ID,Nombre,FechaApertura) values (1,'Almacenes Éxito','20/01/2010');
insert into Tiendas (ID,Nombre,FechaApertura) values (2,'Almacenes Alkosto','20/01/2000');
insert into Tiendas (ID,Nombre,FechaApertura) values (3,'Almacenes Ktronix','20/03/1998');
insert into Tiendas (ID,Nombre,FechaApertura) values (4,'Almacenes Falabella','20/07/2003');
SET IDENTITY_INSERT Tiendas OFF;

SET IDENTITY_INSERT Productos ON;
insert into Productos (Nombre,SKU,Descripcion,Valor,IDTienda,Imagen) 
values ('TV LG 60 pulgadas',1000000,'Televisor LG OLED',2000000,1,'imagenes\\lg60inch');
insert into Productos (Nombre,SKU,Descripcion,Valor,IDTienda,Imagen) 
values ('TV Samsung 60 pulgadas',1000001,'Televisor Samsung Curvo',3400000,1,'imagenes\\samsung60inch');
insert into Productos (Nombre,SKU,Descripcion,Valor,IDTienda,Imagen) 
values ('Portatil HP',1000002,'Portatil HP 14 pulgadas core i 3 4RAM 1TB',2500000,1,'imagenes\\portatilhp');
insert into Productos (Nombre,SKU,Descripcion,Valor,IDTienda,Imagen) 
values ('Apple Macbook Pro',1000003,'Macbook Pro 14 pulgadas core i 5 8RAM 1TB',3500000,1,'imagenes\\macbook');


insert into Productos (Nombre,SKU,Descripcion,Valor,IDTienda,Imagen) 
values ('TV LG 60 pulgadas',1000004,'Televisor LG OLED',2100000,2,'imagenes\\lg60inch');
insert into Productos (Nombre,SKU,Descripcion,Valor,IDTienda,Imagen) 
values ('TV Samsung 60 pulgadas',1000005,'Televisor Samsung Curvo',3300000,2,'imagenes\\samsung60inch');
insert into Productos (Nombre,SKU,Descripcion,Valor,IDTienda,Imagen) 
values ('Portatil HP',1000006,'Portatil HP 14 pulgadas core i 3 4RAM 1TB',2550000,2,'imagenes\\portatilhp');
insert into Productos (Nombre,SKU,Descripcion,Valor,IDTienda,Imagen) 
values ('Apple Macbook Pro',1000007,'Macbook Pro 14 pulgadas core i 5 8RAM 1TB',3550000,2,'imagenes\\macbook');


insert into Productos (Nombre,SKU,Descripcion,Valor,IDTienda,Imagen) 
values ('TV LG 60 pulgadas',1000008,'Televisor LG OLED',1899999,3,'imagenes\\lg60inch');
insert into Productos (Nombre,SKU,Descripcion,Valor,IDTienda,Imagen) 
values ('TV Samsung 60 pulgadas',1000009,'Televisor Samsung Curvo',3200000,3,'imagenes\\samsung60inch');
insert into Productos (Nombre,SKU,Descripcion,Valor,IDTienda,Imagen) 
values ('Portatil HP',1000010,'Portatil HP 14 pulgadas core i 3 4RAM 1TB',2400000,3,'imagenes\\portatilhp');
insert into Productos (Nombre,SKU,Descripcion,Valor,IDTienda,Imagen) 
values ('Apple Macbook Pro',1000011,'Macbook Pro 14 pulgadas core i 5 8RAM 1TB',3490000,3,'imagenes\\macbook');


insert into Productos (Nombre,SKU,Descripcion,Valor,IDTienda,Imagen) 
values ('TV LG 60 pulgadas',1000012,'Televisor LG OLED',1900000,4,'imagenes\\lg60inch');
insert into Productos (Nombre,SKU,Descripcion,Valor,IDTienda,Imagen) 
values ('TV Samsung 60 pulgadas',1000013,'Televisor Samsung Curvo',3290000,4,'imagenes\\samsung60inch');
insert into Productos (Nombre,SKU,Descripcion,Valor,IDTienda,Imagen) 
values ('Portatil HP',1000014,'Portatil HP 14 pulgadas core i 3 4RAM 1TB',2320000,4,'imagenes\\portatilhp');
insert into Productos (Nombre,SKU,Descripcion,Valor,IDTienda,Imagen) 
values ('Apple Macbook Pro',1000015,'Macbook Pro 14 pulgadas core i 5 8RAM 1TB',3400000,4,'imagenes\\macbook');
SET IDENTITY_INSERT Productos OFF;

SET IDENTITY_INSERT Logs ON;