use Control_Cafe;

CREATE TABLE area (
    id_area      VARCHAR(10) NOT NULL,
    descripcion  VARCHAR(50) NOT NULL
);

ALTER TABLE area ADD CONSTRAINT area_pk PRIMARY KEY ( id_area );


CREATE TABLE compra (
    id_compra            VARCHAR(10) NOT NULL,
    cantidad             VARCHAR(50) NOT NULL,
    producto_id_produc   VARCHAR(10) NOT NULL,
    proveedor_id_provee  VARCHAR(10) NOT NULL
);

ALTER TABLE compra ADD CONSTRAINT compra_pk PRIMARY KEY ( id_compra );


CREATE TABLE empleado (
    id_emple            VARCHAR(10) NOT NULL,
    f_ingreso           DATE NOT NULL,
    area_id_area        VARCHAR(10) NOT NULL,
    persona_id_persona  VARCHAR(10) NOT NULL
);

ALTER TABLE empleado ADD CONSTRAINT empleado_pk PRIMARY KEY ( id_emple );



CREATE TABLE inventario (
    id_inven            VARCHAR(10) NOT NULL,
    cantidad            VARCHAR(50) NOT NULL,
    producto_id_produc  VARCHAR(10) NOT NULL,
    compra_id_compra    VARCHAR(10) NOT NULL,
);

ALTER TABLE inventario ADD CONSTRAINT inventario_pk PRIMARY KEY ( id_inven );


CREATE TABLE marca (
    id_marca     VARCHAR(10) NOT NULL,
    descripcion  VARCHAR(50) NOT NULL
);

ALTER TABLE marca ADD CONSTRAINT marca_pk PRIMARY KEY ( id_marca );


CREATE TABLE persona (
    id_persona             VARCHAR(10) NOT NULL,
    nombre                 VARCHAR(50) NOT NULL,
    apellido               VARCHAR(50) NOT NULL,
    dpi                    VARCHAR(50),
    direccion              VARCHAR(50) NOT NULL,
    tipo_persona_id_tpers  VARCHAR(10) NOT NULL
);

ALTER TABLE persona ADD CONSTRAINT persona_pk PRIMARY KEY ( id_persona );


CREATE TABLE producto (
    id_produc                 VARCHAR(10) NOT NULL,
    nombre                    VARCHAR(50) NOT NULL,
    marca_id_marca            VARCHAR(10) NOT NULL
);

ALTER TABLE producto ADD CONSTRAINT producto_pk PRIMARY KEY ( id_produc );


CREATE TABLE proveedor (
    id_provee           VARCHAR(10) NOT NULL,
    persona_id_persona  VARCHAR(10) NOT NULL
);

ALTER TABLE proveedor ADD CONSTRAINT proveedor_pk PRIMARY KEY ( id_provee );


CREATE TABLE tipo_persona (
    id_tpers     VARCHAR(10) NOT NULL,
    descripcion  VARCHAR(50) NOT NULL
);

ALTER TABLE tipo_persona ADD CONSTRAINT tipo_persona_pk PRIMARY KEY ( id_tpers );


CREATE TABLE usuario (
    id_usuario    VARCHAR(10) NOT NULL,
    nomb_usuario  VARCHAR(50) NOT NULL,
    contraseña    VARCHAR(50) NOT NULL
);

ALTER TABLE usuario ADD CONSTRAINT usuario_pk PRIMARY KEY ( id_usuario );




ALTER TABLE compra
    ADD CONSTRAINT compra_producto_fk FOREIGN KEY ( producto_id_produc )
        REFERENCES producto ( id_produc );

ALTER TABLE compra
    ADD CONSTRAINT compra_proveedor_fk FOREIGN KEY ( proveedor_id_provee )
        REFERENCES proveedor ( id_provee );

ALTER TABLE empleado
    ADD CONSTRAINT empleado_area_fk FOREIGN KEY ( area_id_area )
        REFERENCES area ( id_area );

ALTER TABLE empleado
    ADD CONSTRAINT empleado_persona_fk FOREIGN KEY ( persona_id_persona )
        REFERENCES persona ( id_persona );

ALTER TABLE inventario
    ADD CONSTRAINT inventario_compra_fk FOREIGN KEY ( compra_id_compra )
        REFERENCES compra ( id_compra );

ALTER TABLE inventario
    ADD CONSTRAINT inventario_producto_fk FOREIGN KEY ( producto_id_produc )
        REFERENCES producto ( id_produc );

ALTER TABLE persona
    ADD CONSTRAINT persona_tipo_persona_fk FOREIGN KEY ( tipo_persona_id_tpers )
        REFERENCES tipo_persona ( id_tpers );

ALTER TABLE producto
    ADD CONSTRAINT producto_marca_fk FOREIGN KEY ( marca_id_marca )
        REFERENCES marca ( id_marca );

ALTER TABLE proveedor
    ADD CONSTRAINT proveedor_persona_fk FOREIGN KEY ( persona_id_persona )
        REFERENCES persona ( id_persona );
