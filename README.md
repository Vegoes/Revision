# 1 de Outubro
Colocación do ListBox e botons do formulario principal. Creación dun formulario secundario para a recollida de datos

# 3 de Outubro
Problemas con Visual Studio e GitHub. Reinstalación de Visual Studio.

# 5 de Outubro
Volta a facer o do 1 de Outubro

# 6 de Outubro
Comezo de recollida de datos de formulario secundario a formulario principal. Copia-Pega de código de Microsoft para comprobar o funcionamento do ListView, máis adecuado para o que necesito.

# 12 de Outubro
Estudio do ListView. Enlazo Form2 co Form1 para poder introducir novos productos.

# 13 de Outubro
Botons Editar e Borrar habilitados. Pódense borrar productos. Xa se pode editar os productos. De momento non funciona correctamente de todo.

# 14 de Outubro
Botón Novo Alimento totalmente funcional. Rexeita no apartado "Cantidades" que non se introduzca número e no apartado "Data de Caducidade" que non  se introduza unha data correcta. Se non se introducen os tres campos obligatorios, non introduce novo producto. "Deshabilitado" Botón Editar a espera de poder escribir un código acorde ao seu funcionamento.

# 17 de Outubro
Solucionado o erro que saltaba cando se introducían cantidades maiores que 9. Engádese novos MessageBox avisando ao usuario que ten que seleccionar o producto se o quere editar/borrar.
Aproveitamento do código de Botón Novo para poder utilizalo tamén no Botón Editar.

# 19 de Outubro
Solucionado o erro que permitía introducir números negativos en "Cantidades". Refinamento do Botón Editar que agora so funciona cando so seleccionas un producto.

Creación da BD para poder gardar productos. Instalación de DB Browser para crear a Base de Datos. Instalación da Librería System.Data.SQLite.Core e Dapper para o acceso da Aplicación a BD (Se algunha das librerías/programa usados non a podo usar, volvo a refacer todo xD). Problemas para acceder ao dato "Lugar" na BD xa que non detecta dato, devolve un NULL. O dato está gardado na BD, pero non se pode despois recuperar o dato. 

Anulado de momento para gardar productos na BD. Cada vez que gardo o ListView na BD, gardo todo. De momento non pode gardar datos na BD.

# 20 de Outubro
Solucionado o bug que impedía mostrar o Lugar de Compra do producto.

# 24 de Outubro
Habilitada na aplicación o poder gardar os productos na BD. Mini avance (esqueleto) para poder borrar o producto que queiras. De momento non elimina nada.

# 28 de Outubro
A Aplicación pode eliminar os productos da BD, pero non funciona correctamente. O código para Editar está xa escrito, pero falta pasar a List de Form1 a Form2 para poder editar ben.

# 1 de Novembro
A Aplicación pode introducir, eliminar e editar productos e volcar os datos correctamente na BD.

# 7 de Novembro
Creación dunha Web Service que poida mostrar os productos sen stock. De momento so houbo unha toma de contacto.

# 9 de Novembro
Creación dunha Web Api Service que mostra una lista de productos sen stock. Instalación da Librería EntityFrameworkCore para poder realizar consultas coa Web Api Service
