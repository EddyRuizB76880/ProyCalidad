
# Universidad de Costa Rica

# Documento de conceptualización

# EMPRENDE@UCR

# Version 1.0

[Referencia al control de versiones actual para el documento y el sistema](https://bitbucket.org/cristian_quesadalopez/ecci_ci0128_i2021_g01_pi/src/master/)

**Tabla de contenidos**

1. [Definiciones, acrónimos y abreviaciones](#Def)
2. [Introducción](#Intro)
3. [Listado de equipos y miembros](#Teams)
    - [Roles de iteración](#Roles)
4. [Descripción general del sistema a desarrollar](#id4)
    - [Contexto y situación actual](#Contexto)
    -  [Problema que resuelve](#Trouble)
    -  [Interesados del proyecto y tipos de usuarios](#Interesados)
    -  [Solución propuesta](#Solution)
    - [Análisis del entorno](#Anal)
    - [Visión del producto](#Vision)
    - [Relación con otros sistemas externos](#Relation)
    - [Descripción de los módulos y epics](#Epic)
    - [Requerimientos Funcionales](#Requirements)
    - [Product Road Map](#ProductRoadMap)
    - [Requerimientos no funcionales](#NonFuncRequirements)
5. [Artefactos de bases de datos](#ArtefactosBases)
    - [Esquema conceptual](#ERR)
    - [Esquema lógico](#Mapeo)
6. [Decisiones técnicas](#Decitions)
    - [Metodologías utilizadas](#Metodology)
    - [Artefactos utilizadas en el desarrollo](#Artefactos)
    - [Tecnologías utilizadas](#Tecnology)
    - [Repositorio de código & estrategia git](#Git)
    - [Definición de listo](#DOD)
7. [Referencias bibliográficas](#Ref)


## Definiciones, acrónimos y abreviaciones<a name="Def"></a>

## Introducción<a name="Intro"></a>

## Listado de equipos y miembros<a name="Teams"></a>

### Roles de iteración<a name="Roles"></a>

#### 3DKR:
    Rafael Porras       ->  Documentación
    Kevin Salas         ->  Look and feel
    Daniel Mayorga      ->  Scrum ambassador
    Dario Matamoros     ->  Bases de Datos
    Donaldo Salas       ->  Scrum master
    Andrés Chaves       ->  Estrategias Git

#### Phoenix:
    Alejandro Ramirez   ->  Documentación
    Luis Ureña          ->  Look and Feel
    Andres Zamora       ->  Scrum Master
    Hellen Fuentes      ->  Scrum ambassador
    Erick  Murillo      ->  Base de Datos
    Jean Carlo Quesada  ->  Estrategias Git

#### Pandemic:
    Manfred Carvajal    ->   Documentación
    Diego Barquero      ->   Look and feel
    Luis Rojas          ->   Scrum ambassador
    Jostyn Delgado      ->   Bases de Datos
    Isaac Herrera       ->   Scrum master/Documentación
    Johel Phillips      ->   Estrategias Git

#### F & ½L:
    Juan Valverde       ->   Scrum Master
    Herson Mena         ->   Bases de Datos
    Hansel Calderon     ->   Look and feel
    Sebastian Chavez    ->   Estrategias Git
    Silvia Aguilar      ->   Scrum Ambassador
    Eddy Ruiz           ->   Documentación

## Descripción general del sistema a desarrollar<a name="id4"></a>

### Contexto y situación actual<a name="Contexto"></a>

Debido a la pandemia por el coronavirus, existen muchas personas que se han quedado sin trabajo o no han podido hacer ventas de sus negocios. Por este motivo se decidió realizar una página web que permita a cualquier emprendedor promocionar y vender su producto o servicio.

### Problema que resuelve<a name="Trouble"></a>

Le permite a los emprendedores de cualquier tamaño dar a conocer sus productos y servicios permitiendo un canal comunicación entre el cliente y el emprendedor.

### Interesados del proyecto y tipos de usuarios<a name="Interesados"></a>

Los interesados del proyecto son los emprendedores que deseen vender su producto/servicio por medio de la página, así como los clientes que estén interesados en algún producto o servicio.

#### Tipos de Usuario:

*Emprendedor:* Perfil de la persona/empresa que vende servicios o productos.

*Cliente:* Perfil de la persona que desea comprar algún servicio o producto.

*Administrador:* El encargado de administrar la página web.


### Solución propuesta<a name="Solution"></a>

La solución propuesta es realizar una página web que permita tanto promocionar productos o servicios como realizar las compras dentro de la página. Además la página contará con un canal de comunicación directo(chat) entre cliente y emprendedor que permitirá que ambas partes se pongan de acuerdo en la orden y entrega del pedido/servicio. La app también permitirá crear alianzas entre emprendedores.


### Análisis del entorno<a name="Anal"></a>

### Visión del producto<a name="Vision"></a>(ISAAC)

Para los emprendedores nacionales, quienes necesitan un medio para promocionar y vender sus productos y/o servicios, EMPRENDE@UCR es una plataforma web que permite la venta y compra en línea de productos y servicios. A diferencia de otras plataformas no enfocadas en los pequeños emprendedores, nuestro producto, además de ser gratuito, busca el crecimiento de los pequeños emprendedores y fomenta la cooperación entre estos.

### Relación con otros sistemas externos<a name="Relation"></a>

Los módulos del sistema web tiene relación con otros sistemas que ya existan.
ejemplo: la parte de los pagos, preguntar a la po si visualiza otros sistemas que quiera integrarle (facturas)


### Descripción de los módulos y epics<a name="Epic"></a> (Manfred)

### Requerimientos Funcionales<a name="Requirements"></a> (EDDY)
Crear una plataforma virtual en linea donde emprendedores puedan juntarse con compradores y asi negociar entre ellos:
- Permitir el registro de distintos tipos de usuarios.(Administradores de sitio, compradores y emprendedores)  
- Permitir a emprendedores publicar fotos y descripciones de los productos que vende, asi como sus datos de contacto y forma de operar junto con metodos de pago aceptados.
- Permitir a emprendedores dar seguimiento a ordenes que hayan sido hechas por sus clientes.
- Permitir a compradores llenar un carrito de compras con productos o servicios (pero no ambos) de un mismo emprendedor.
- Permitir a compradores finalizar su compra por medio del paso de "checkout", donde puedan ver en una pantalla los contenidos del carrito de compra y el valor individual de cada uno, al igual del valor total de todo lo incluido en el carrito. En el checkout, debe haber un boton para confirmar la compra.
- Permitir a compradores elegir el metodo de pago que desean usar para finalizar su compra.
### Product Road Map<a name="ProductRoadMap"></a> (Alejandro)

### Requerimientos no funcionales<a name="NonFuncRequirements"></a> (Isaac)

## Artefactos de bases de datos<a name="ArtefactosBases"></a>

### Esquema conceptual<a name="ERR"></a>

![Esquema conceptual de la base de datos](AQUI_VA_EL_NOMBRE_DEL_ARCHIVO_PNG)

Referencia al archivo fuente: [Esquema conceptual de la base de datos](https://lucid.app/lucidchart/521c91fc-fdbb-42cb-8564-09c0ab52c460/edit?page=0_0#)

### Esquema lógico<a name="Mapeo"></a>

![Esquema lógico de la base de datos](AQUI_VA_EL_NOMBRE_DEL_ARCHIVO_PNG)

Referencia al archivo fuente: [Esquema lógico de la base de datos](https://lucid.app/lucidchart/521c91fc-fdbb-42cb-8564-09c0ab52c460/edit?page=eAhCgoWCmbE2#)

## Decisiones técnicas<a name="Decitions"></a>

### Metodologías utilizadas<a name="Metodology"></a> (Alejandro)

### Artefactos utilizadas en el desarrollo<a name="Artefactos"></a>

**Product Backlog:**

Durante el sprint 0, se asignaron módulos a cada equipo de desarrolladores y a partir de los requerimientos de la P.O, se asignaron EPICS<a name="Epic"></a> e historias de usuario para cada equipo.

**Sprint Backlog:**
Según las tareas prioritarias del backlog, se realizó un product roadmap<a name="ProductRoadMap"></a> en el cuál seleccionaron historias de usuario.


### Tecnologías utilizadas<a name="Tecnology"></a> (Isaac)

### Repositorio de código & estrategia git<a name="Git"></a> (La gente de git)

### Definición de listo<a name="DOD"></a>

La definición de listo (DOD) abarca los siguientes aspectos:

- **Arquitectura:**
    - Obedecer los principios SOLID.

- **Producto:**
    - El código debe cumplir los sigiuentes principios:
        - YAGNI
        - KISS
        - DRY
      
    - El código debe ser probado con unit testing.
    - El código debe aprobar el linter de [Google.](https://google.github.io/styleguide/csharp-style.html)

- **Repositorio:**
    - Verificar la funcionalidad antes de fusionar una funcionalidad con el master.

- **Validación de historias con PO:**
    - Las historias deben de ser aceptadas por el equipo y el PO, antes de llevarse a un sprint.
    - Las hisotrias de usuarios deben ser INVEST.

- **Intragrupal:**
    - Cualquier funcionaldiad que se agregue no debe afectar a los demás equipos.
    - Comprobar las funcionaldiades complementarias entre los grupos.

## Referencias bibliográficas<a name="Ref"></a> (Manfred)