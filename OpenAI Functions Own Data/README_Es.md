# Sistema de preguntas y respuestas en una base de datos personalizada (Proyecto OpenAI API + SQL)

Creación de un sistema de preguntas y respuestas que responde como ChatGPT pero obtiene las respuestas de una base de datos interna de una universidad ficticia utilizando la API de OpenAI (OpenAI Function Calling). Aplicación escrita en Python (Backend) y Streamlit (Frontend)<br>
Simplemente haga una pregunta en el área de entrada (Input) y el sistema obtendrá la respuesta de una base de datos interna imaginaria de una universidad ficticia.

**Ejemplo de pregunta al sistema**<br>
![01 Preview](./Images_README.md/01_Preview.png)

**Comprobación de preguntas y respuestas en un software de base de datos clásico (MySQL)**<br>
![02 Preview in SQL](./Images_README.md/02_Preview_SQL.png)


## Ejemplos de preguntas para hacer pruebas
Aquí hay algunos ejemplos de preguntas que se pueden hacer a este sistema de preguntas y respuestas (Se tiene que consultar en inglés).

**Ejemplo 1**<br>
What was Peter Pandey's GPA in semester 1?<br>
![01 Streamlit](./Images_README.md/03_01_Streamlit.png)
![01 MySQL](./Images_README.md/04_01_MySQL.png)

**Ejemplo 2**<br>
Peter Pandey GPA in firts semester<br>
![02 Streamlit](./Images_README.md/05_02_Streamlit.png)
![02 MySQL](./Images_README.md/04_01_MySQL.png)

**Ejemplo 3**<br>
How much is peter pandey's pending fees in the first semester?<br>
![03 Streamlit](./Images_README.md/06_03_Streamlit.png)
![03 MySQL](./Images_README.md/07_03_MySQL.png)

**Ejemplo 4**<br>
How much was peter pandey's due fees in the semester 1?<br>
![04 Streamlit](./Images_README.md/08_04_Streamlit.png)
![04 MySQL](./Images_README.md/07_03_MySQL.png)

## Tecnología usadas

```commandline
Base de datos: MySQL
Backend: Python + OpenAI API Function Calling
Frontend: Streamlit
```

## Configuración

1. Base de datos: En la carpeta _db_ verá un archivo script SQL que simplemente tendrá que ejecutar por completo en MySQL Workbench (schema atliq_college_db)<br>
![08a Create db](./Images_README.md/08a_Create_db.png)
2. Código Python: Necesitas instalar los siguientes módulos
   ```commandline
   pip install -r requirements.txt
   ```
3. Configuración de la API de OpenAI: Debe obtener una clave secreta de su cuenta de OpenAI y colocarla en el archivo _secret_key.py_ . Debe crear una cuenta en la web de desarrolladores de OpenAI y se le dará un crédito inicial de $ 5 que debería ser suficiente para el proyecto, luego puede comprar más créditos.

## Ejecutando streamlit app

Desde una terminal ejecute este comando
```commandline
streamlit run main.py
```

## Explicación de los archivos
**db_helper.py**<br>
Código Python que se conecta a MySQL Workbench.<br>
![09 db helper](./Images_README.md/09_db_helper.png)

**openai_helper.py**<br>
Código Python que envía el texto al servidor OpenAI y devuelve el resultado como un string.<br>
![10 openai helper](./Images_README.md/10_openai_helper.png)

**main.py**<br>
Código Python que gestiona el Frontend con Streamlit.<br>
![11 main](./Images_README.md/11_main.png)
