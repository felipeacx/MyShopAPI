INSTALACIÓN

Para la instalación debemos realizar la copia del proyecto a Visual Studio 2019.
Vamos a añadir controlador luego escogemos Controlador de MVC con vistas que usan Entity Framework.
En clase del modelo seleccionamos: Tienda y en clase de contexto de datos creamos una si no nos deja seleccionar ninguna,
poniendole el nombre ControladorDBTiendas.
Nos dirigimos a herramientas-Administrador de paquetes NuGet-Consola del Administrador de paquetes.
En la consola que se nos despliega seleccionamos Proyecto predeterminado: MyShopApi.
Luego ejecutamos el comando  add-migration dbmigration esperamos que finalice
y ejecutamos el comando update-database.
Lo anterior lo hacemos para crear la base de datos con Entity Framework Code First.
Luego creamos el controlador API, para esto vamos a añadir controlador y escogemos Controlador API: en blanco.
Aqui configuramos los verbos http para realizar las peticiones a la base de datos cuanto el usuario ingrese.
Por último debemos llenar las tablas con algunos datos. Para esto ejecutamos el script SQLQuery.sql.

EJECUCIÓN Y FUNCIONAMIENTO

Al ejecutarlo a traves de Visual Studio nos dirige a la ruta por defecto que es:
http://localhost:50373/Tiendas
En esta ruta vemos todas las tiendas registradas.
Para ver una tienda con todos sus productos ofrecidos nos dirigimos a:
http://localhost:50373/Tiendas/id
donde id es el id de la tienda que pudimos distinguir anteriormente.
para ver el log de eventos nos dirigimos a:
http://localhost:50373/Tiendas/logs
Asi mismo si deseamos borrar:
http://localhost:50373/Tiendas/id
a traves de Postman con el verbo http delete
actualizar:
http://localhost:50373/Tiendas/id
a traves de Postman con el verbo http put
y registrar:
http://localhost:50373/Tiendas/id
a traves de Postman con el verbo http post

Por último realice la publicacion de la API en Azure la cual se puede consultar en:
https://apimitienda.azurewebsites.net/Tiendas
