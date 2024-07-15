CREATE TABLE employees
(
	id INT PRIMARY KEY Identity(1,1),
	employee_id varchar(max) null,
	full_name varchar(max) null,
	gender varchar(max) null,
	contact_number varchar(max) null,
	position varchar(max) null,
	image varchar(max) null,
	salary int null,
	insert_date Date null,
	update_date Date null,
	delete_Date Date null
);

select * from employees;


alter table employees
add status varchar(max) null
