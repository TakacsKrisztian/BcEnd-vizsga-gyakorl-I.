create table jegyek (
	id INT PRIMARY KEY AUTO_INCREMENT,
	jegy_szammal INT(1),
	jegy_szoveggel VARCHAR(10),
	beiras_datuma DATE,
	modositas_datuma DATE,
	id_tanarok INT,
	id_tantargyak INT
);
insert into jegyek (id, jegy_szammal, jegy_szoveggel, beiras_datuma, modositas_datuma, id_tanarok, id_tantargyak) values (1, 3, 'közepes', '2022-04-25', '2023-02-18', 1, 1);
insert into jegyek (id, jegy_szammal, jegy_szoveggel, beiras_datuma, modositas_datuma, id_tanarok, id_tantargyak) values (2, 1, 'elégtelen', '2022-05-21', '2022-04-27', 1, 2);
insert into jegyek (id, jegy_szammal, jegy_szoveggel, beiras_datuma, modositas_datuma, id_tanarok, id_tantargyak) values (3, 2, 'elégséges', '2022-12-22', '2022-06-25', 3, 2);
insert into jegyek (id, jegy_szammal, jegy_szoveggel, beiras_datuma, modositas_datuma, id_tanarok, id_tantargyak) values (4, 5, 'jeles', '2022-09-18', '2022-11-10', 4, 4);
insert into jegyek (id, jegy_szammal, jegy_szoveggel, beiras_datuma, modositas_datuma, id_tanarok, id_tantargyak) values (5, 2, 'elégséges', '2022-07-13', '2022-09-15', 5, 5);
insert into jegyek (id, jegy_szammal, jegy_szoveggel, beiras_datuma, modositas_datuma, id_tanarok, id_tantargyak) values (6, 4, 'jó', '2022-04-14', '2022-10-25', 6, 6);
