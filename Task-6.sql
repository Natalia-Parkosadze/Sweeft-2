CREATE TABLE Teacher (
  id INT PRIMARY KEY,
  first_name VARCHAR(50) NOT NULL,
  last_name VARCHAR(50) NOT NULL,
  gender ENUM('M', 'F') NOT NULL,
  subject VARCHAR(50) NOT NULL
);

CREATE TABLE Pupil (
  id INT PRIMARY KEY,
  first_name VARCHAR(50) NOT NULL,
  last_name VARCHAR(50) NOT NULL,
  gender ENUM('M', 'F') NOT NULL,
  class VARCHAR(50) NOT NULL
);

SELECT t.* 
FROM Teacher t
INNER JOIN Pupil p ON t.subject = p.class
WHERE p.first_name = 'Giorgi' AND p.last_name = 'lastname';