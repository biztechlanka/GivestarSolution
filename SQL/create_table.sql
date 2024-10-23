CREATE TABLE document_type
(
	id INT GENERATED BY DEFAULT AS IDENTITY 
    (START WITH 100 INCREMENT BY 1) PRIMARY KEY, 
	document_type_name VARCHAR(500),
	is_required BOOLEAN DEFAULT TRUE,
	required_parts INT DEFAULT 1,
	comments VARCHAR(500),
	is_enabled BOOLEAN DEFAULT TRUE,
	created_datetime TIMESTAMP
);