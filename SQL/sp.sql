
CREATE OR REPLACE PROCEDURE get_document_types()
LANGUAGE plpgsql
AS 
$BODY$
BEGIN
	SELECT 
	id AS "Id", 
	document_type_name AS "DocumentTypeName", 
	is_required AS "IsRequired", 
	required_parts AS "RequiredParts", 
	comments AS "Comments"
	FROM 
	public.document_type
	WHERE
	is_enabled=true;
END
$BODY$

CALL get_document_types()
	