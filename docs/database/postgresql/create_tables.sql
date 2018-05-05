-- Table: insurance_policy

-- DROP TABLE insurance_policy;

CREATE TABLE insurance_policy
(
    "Id" bigint NOT NULL,
    "Name" character varying(100) NOT NULL,
    "Description" character varying(4000) NOT NULL,
    "CoverageType" integer NOT NULL,
    "StartDate" date NOT NULL,
    "CoveragePeriod" integer NOT NULL,
    "Price" double precision NOT NULL,
    "RiskType" integer NOT NULL,
    CONSTRAINT insurance_policy_pkey PRIMARY KEY (Id)
);

ALTER TABLE public.insurance_policy
    OWNER to postgres;