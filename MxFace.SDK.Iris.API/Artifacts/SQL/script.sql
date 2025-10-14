CREATE TABLE IF NOT EXISTS public."__IrisSubjects"
(
    "Id" integer NOT NULL,
    "SubjectId" character varying(45) COLLATE pg_catalog."default",
    "Template" bytea,
    "Group" character varying(45) COLLATE pg_catalog."default",
    "ClientId" integer
)