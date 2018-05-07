-- Table: public.insurance_coverage_type

-- DROP TABLE public.insurance_coverage_type;

CREATE TABLE public.insurance_coverage_type
(
    coverage_type_id bigint NOT NULL DEFAULT nextval('insurance_coverage_type_coverage_type_id_seq'::regclass),
    name character varying(200) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT insurance_coverage_type_pkey PRIMARY KEY (coverage_type_id)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.insurance_coverage_type
    OWNER to postgres;

-- Table: public.insurance_policy

-- DROP TABLE public.insurance_policy;

CREATE TABLE public.insurance_policy
(
    "Id" bigint NOT NULL DEFAULT nextval('"insurance_policy_Id_seq"'::regclass),
    "Name" character varying(100) COLLATE pg_catalog."default" NOT NULL,
    "Description" character varying(4000) COLLATE pg_catalog."default" NOT NULL,
    "CoverageType" integer NOT NULL,
    "StartDate" date NOT NULL,
    "CoveragePeriod" integer NOT NULL,
    "Price" double precision NOT NULL,
    "RiskType" integer NOT NULL,
    CONSTRAINT insurance_policy_pkey PRIMARY KEY ("Id")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.insurance_policy
    OWNER to postgres;

-- Table: public.insurance_risk_type

-- DROP TABLE public.insurance_risk_type;

CREATE TABLE public.insurance_risk_type
(
    insurance_risk_type bigint NOT NULL DEFAULT nextval('insurance_risk_type_insurance_risk_type_seq'::regclass),
    name character varying(200) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT insurance_risk_type_pkey PRIMARY KEY (insurance_risk_type)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.insurance_risk_type
    OWNER to postgres;

-- Table: public.insurance_user

-- DROP TABLE public.insurance_user;

CREATE TABLE public.insurance_user
(
    user_id bigint NOT NULL DEFAULT nextval('insurance_user_user_id_seq'::regclass),
    name character varying(50) COLLATE pg_catalog."default" NOT NULL,
    last_name character varying(50) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT insurance_user_pkey PRIMARY KEY (user_id)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.insurance_user
    OWNER to postgres;

-- Table: public.user_insurance_policy

-- DROP TABLE public.user_insurance_policy;

CREATE TABLE public.user_insurance_policy
(
    user_id bigint NOT NULL,
    insurance_policy_id bigint NOT NULL,
    CONSTRAINT user_insurance_policy_pkey PRIMARY KEY (user_id, insurance_policy_id)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.user_insurance_policy
    OWNER to postgres;


-- Relations
ALTER TABLE public.user_insurance_policy
ADD CONSTRAINT user_insurance_policy_insurance_user 
FOREIGN KEY (user_id) REFERENCES public.insurance_user(user_id);

ALTER TABLE public.user_insurance_policy
ADD CONSTRAINT user_insurance_policy_insurance_policy 
FOREIGN KEY (insurance_policy_id) REFERENCES public.insurance_policy("Id");

ALTER TABLE public.insurance_policy
ADD CONSTRAINT insurance_policy_insurance_coverage_type 
FOREIGN KEY ("CoverageType") REFERENCES public.insurance_coverage_type(coverage_type_id);

ALTER TABLE public.insurance_policy
ADD CONSTRAINT insurance_policy_insurance_risk_type
FOREIGN KEY ("RiskType") REFERENCES public.insurance_risk_type(risk_type_id);