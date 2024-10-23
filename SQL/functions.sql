DROP FUNCTION func_get_document_types()

CREATE OR REPLACE FUNCTION func_get_document_types()
RETURNS TABLE (
	"Id" INT,
	"DocumentTypeName" VARCHAR(500),
	"IsRequired" BOOLEAN,
	"RequiredParts" INT,
	"Comments" VARCHAR(500)
) AS $$
BEGIN
	RETURN QUERY
		SELECT 
		id, 
		document_type_name, 
		is_required, 
		required_parts, 
		comments
		FROM 
		public.document_type
		WHERE
		is_enabled=true;
END
$$ LANGUAGE plpgsql

EXPLAIN ANALYZE select * from public.func_get_document_types()
