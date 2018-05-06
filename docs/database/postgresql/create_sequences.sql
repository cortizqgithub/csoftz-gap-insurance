CREATE SEQUENCE public.insurance_coverage_type_coverage_type_id_seq
    INCREMENT 1
    START 4
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 1;

ALTER SEQUENCE public.insurance_coverage_type_coverage_type_id_seq
    OWNER TO postgres;

CREATE SEQUENCE public."insurance_policy_Id_seq"
    INCREMENT 1
    START 1
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 1;

ALTER SEQUENCE public."insurance_policy_Id_seq"
    OWNER TO postgres;

CREATE SEQUENCE public.insurance_risk_type_insurance_risk_type_seq
    INCREMENT 1
    START 4
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 1;

ALTER SEQUENCE public.insurance_risk_type_insurance_risk_type_seq
    OWNER TO postgres;

CREATE SEQUENCE public.insurance_user_user_id_seq
    INCREMENT 1
    START 1
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 1;

ALTER SEQUENCE public.insurance_user_user_id_seq
    OWNER TO postgres;

