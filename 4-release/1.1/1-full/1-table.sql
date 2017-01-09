create table party (party_id int, party_name)
go
create table employment(party_id, position_id, start_date, end_date, seniority float)
go
create table employee(party_id int, employee_no varchar(16), hire_date datetime, resign_date datetime, extra_seniority float)
go
