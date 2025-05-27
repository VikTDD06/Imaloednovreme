INSERT INTO dentists(name, family)
VALUES
('Roberto', 'Jovanni'),
('Ivan', 'Petrov'),
('Yana', 'Ivanova');

INSERT INTO patients(name, family, birthdate, dentist_id )
VALUES
('John', 'Smith', '1971-05-23', 1),
('Petar', 'Petrov', '1972-12-12', 3),
('Ana', 'Antonova', '1982-02-21', 2),
('Boris', 'Borisov', '1977-09-11', 2),
('Georgi', 'Georgiev', '2001-06-22', 1),
('Svetla', 'Svetlinova', '1991-04-18', 3),
('Viktor', 'Krumov', '1992-05-05', 2);

INSERT INTO examinations(patient_id , dentist_id , appointment , exam_end )
VALUES
(1, 1, '2021-08-14 10:30:00', '2021-08-14 10:55:00'),
(3, 2, '2021-08-14 11:00:00', '2021-08-14 11:25:00'),
(4, 2, '2021-08-14 11:30:00', '2021-08-14 11:55:00'),
(6, 3, '2021-08-15 09:30:00', '2021-08-14 09:55:00'),
(1, 1, '2022-08-14 10:30:00', '2022-08-14 10:55:00');
