/*
DROP TABLE IF EXISTS Section
DROP TABLE IF EXISTS Bookmarks;
DROP TABLE IF EXISTS Enrollment;
DROP TABLE IF EXISTS Announcement;
DROP TABLE IF EXISTS LectureNote;
DROP TABLE IF EXISTS Quiz;
DROP TABLE IF EXISTS Assignment;
DROP TABLE IF EXISTS Courses;
DROP TABLE IF EXISTS Users;
*/

-- Users Table
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
	uname VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    passwordd VARCHAR(255) NOT NULL,
    UserType VARCHAR(255) NOT NULL CHECK (UserType IN ('Instructor', 'Student', 'Administrator'))
);

-- Insert the administrator
INSERT INTO Users (uname, Email, passwordd, UserType) VALUES 
('Kissa', 'admin@gmail.com', 'admin', 'Administrator');

-- Insert students and Instructors
INSERT INTO Users (uname, Email, passwordd, UserType) VALUES 
    ('Hamna','hamna@gmail.com', 'hamna', 'Student'),
    ('Kristy','kristy@hotmail.com', 'kissa', 'Student'),
    ('Arham','arham@yahoo.com', 'arham', 'Student'),
    ('Elijah','elijah@gmail.com', 'elijah', 'Instructor'),
    ('Sarah','sarah@outlook.com', 'sarah', 'Student'),
    ('John','john@outlook.com', 'john', 'Instructor'),
    ('Rory','rory@gmail.com', 'rory', 'Instructor'),
    ('Ted','ted@gmail.com', 'ted', 'Student'),
    ('Sam','sam@gmail.com', 'sam', 'Student');

select * from Users;

-- Courses Table
CREATE TABLE Courses (
    CourseID INT PRIMARY KEY IDENTITY,
    CourseName VARCHAR(255) NOT NULL,
    InstructorID INT,
    FOREIGN KEY (InstructorID) REFERENCES Users(UserID)
);

INSERT INTO Courses (CourseName, InstructorID) VALUES
	('SE', 5),
	('Web Programming', 7),
	('AI', 8),
	('PDC', 5),
	('Numerical', 8),
	('CNet', 5),
	('DIP', 7);

-- Content Table
CREATE TABLE Assignment (
    AssignmentID INT PRIMARY KEY IDENTITY,
	CourseID INT,
	Section VARCHAR(255),
    Deadline VARCHAR(255),
	AssignmentFilePath VARCHAR(255),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);
select * from Assignment;

CREATE TABLE Quiz (
    QuizID INT PRIMARY KEY IDENTITY,
	StudentID INT,
	Section VARCHAR(255),
	CourseID INT,
	QuizFilePath VARCHAR(255),
	FOREIGN KEY (StudentID) REFERENCES Users(UserID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);
select * from Quiz

CREATE TABLE LectureNote (
    LectureNoteID INT PRIMARY KEY IDENTITY,
	Section VARCHAR(255),
	CourseID INT,
	NotesFilePath VARCHAR(255),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

select * from LectureNote

CREATE TABLE Announcement (
    AnnouncementID INT PRIMARY KEY IDENTITY,
	CourseID INT,
	Section VARCHAR(255),
	announcements VARCHAR(255),	--uploaded content
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);
select * from Announcement

--multiple entries for a student according to course 

--Section ka table
CREATE TABLE Section (
  SectionID INT PRIMARY KEY IDENTITY,
  CourseID INT,
  SectionName VARCHAR(255) NOT NULL,

);

Insert into Section values
('A'),
('B'),
('C'),
('D'),
('E'),
('F'),
('G'),
('H'),
('Y'),
('Z'),
('All');

-- Enrollment Table


drop table Enrollment
select * from Enrollment
select * from users
select * from Courses
select * from Assignment



CREATE TABLE Enrollment (
    EnrollmentID INT PRIMARY KEY IDENTITY,
	Section varchar(255),
    UserID INT,
    CourseID INT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID),
);
insert into Enrollment (Section,UserID,CourseID) values 
('A',2,1),
('B',3,1),
('C',4,1);


CREATE TABLE StudentNotes (
    NoteID INT PRIMARY KEY IDENTITY,
    UserID INT,
    FilePath NVARCHAR(MAX),
    CONSTRAINT FK_StudentNotes_UserID FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
select * from StudentNotes

 
DROP TABLE IF EXISTS Bookmarks;
-- Bookmarks Table
CREATE TABLE Bookmarks (
    BookmarkID INT PRIMARY KEY IDENTITY,
    UserID INT,
    CourseID INT,
	AssignmentID INT,
	QuizID INT,
	ValueBookmark bit,
	
	LectureNoteID INT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID),
    FOREIGN KEY (LectureNoteID) REFERENCES LectureNote(LectureNoteID),
	FOREIGN KEY (AssignmentID) REFERENCES Assignment(AssignmentID),
	Foreign key (QuizID) references Quiz(QuizID)
	
);
select * from Bookmarks
delete from Bookmarks

SELECT Assignment.AssignmentID AS [Assignment number], 
       Assignment.Deadline, 
       Assignment.AssignmentFilePath AS download,
       Bookmarks.ValueBookmark AS Bookmarks -- Remove ISNULL
FROM Enrollment 
JOIN Assignment ON Enrollment.CourseID = Assignment.CourseID 
                   AND Enrollment.Section = Assignment.Section
LEFT JOIN Bookmarks ON Enrollment.UserID = Bookmarks.UserID
                  AND Enrollment.CourseID = Bookmarks.CourseID
                  AND Assignment.AssignmentID = Bookmarks.AssignmentID 
WHERE Enrollment.UserID = 2 
      AND Enrollment.CourseID = 1; 

--query 
SELECT DISTINCT Assignment.AssignmentID AS [Assignment number], Assignment.Deadline, Assignment.AssignmentFilePath AS download, Bookmarks.ValueBookmark AS Bookmarks FROM Assignment LEFT JOIN Bookmarks ON Assignment.AssignmentID = Bookmarks.AssignmentID WHERE Assignment.CourseID = 1  AND Bookmarks.UserID = 2;


--query
SELECT  Assignment.AssignmentID AS [Assignment number], 
                Assignment.Deadline, 
                Assignment.AssignmentFilePath AS download, 
                Bookmarks.ValueBookmark AS Bookmarks 
FROM Enrollment 
JOIN Assignment ON Enrollment.CourseID = Assignment.CourseID 
                   AND Enrollment.Section = Assignment.Section	
LEFT JOIN Bookmarks ON Assignment.AssignmentID = Bookmarks.AssignmentID 
                       AND Bookmarks.UserID = 2 
WHERE Enrollment.UserID = 2
      AND Enrollment.CourseID = 1; 


--Bookmark wali
SELECT DISTINCT Assignment.AssignmentID AS [Assignment number], 
                Assignment.Deadline, 
                Assignment.AssignmentFilePath AS download, 
                Bookmarks.ValueBookmark AS Bookmarks 
FROM Enrollment 
JOIN Assignment ON Enrollment.CourseID = Assignment.CourseID 
                   AND Enrollment.Section = Assignment.Section
LEFT JOIN Bookmarks ON Assignment.AssignmentID = Bookmarks.AssignmentID 
                       AND Bookmarks.UserID = 2
WHERE Enrollment.UserID = 2 
      AND Enrollment.CourseID = 1
      AND Bookmarks.ValueBookmark = 1; 

--quiz ka
SELECT Quiz.QuizID AS [Quiz number], 
       Quiz.QuizFilePath AS download,
       Bookmarks.ValueBookmark AS Bookmark
FROM Enrollment 
JOIN Quiz ON Enrollment.CourseID = Quiz.CourseID 
         AND Enrollment.Section = Quiz.Section 
LEFT JOIN Bookmarks ON Enrollment.UserID = Bookmarks.UserID
                   AND Enrollment.CourseID = Bookmarks.CourseID
                   AND Quiz.QuizID = Bookmarks.QuizID -- Join condition for Quiz bookmarks
WHERE Enrollment.UserID = 2 
      AND Enrollment.CourseID = 1; 

--quiz bookmark
SELECT DISTINCT Quiz.QuizID AS [Quiz number], 
                Quiz.QuizFilePath AS download,
                Bookmarks.ValueBookmark AS Bookmarks
FROM Enrollment 
JOIN Quiz ON Enrollment.CourseID = Quiz.CourseID 
         AND Enrollment.Section = Quiz.Section 
JOIN Bookmarks ON Quiz.QuizID = Bookmarks.QuizID 
                  AND Bookmarks.UserID = 2
                  AND Bookmarks.ValueBookmark = 1 
WHERE Enrollment.UserID = 2
      AND Enrollment.CourseID = 1; 

--modified quizBookmark
SELECT DISTINCT Quiz.QuizID AS [Quiz number], 
                Quiz.QuizFilePath AS download, 
                Bookmarks.ValueBookmark AS Bookmarks
FROM Bookmarks 
JOIN Quiz ON Bookmarks.QuizID = Quiz.QuizID 
WHERE Bookmarks.UserID = 2--@userID 
  AND Bookmarks.CourseID =1-- @courseID
  AND Bookmarks.ValueBookmark = 1; 


  --dashboard
Select distinct e.CourseID,  c.CourseName AS [Course Name], u.uname AS [Instuctor Name ] 
FROM Enrollment AS E
INNER JOIN Users AS U ON E.UserID = U.UserID AND U.UserType = 'Instructor'
INNER JOIN Courses AS C ON E.CourseID = C.CourseID
WHERE EXISTS (
    SELECT 1
    FROM Enrollment AS E2
    WHERE E2.Section	 = E.Section
    AND E2.UserID IN (
        SELECT UserID
        FROM Users
        WHERE UserType = 'Student'
        AND UserID = 2
    )
);

--.....
SELECT Enrollment.CourseID, 
       c.CourseName AS [Course Name], 
       u.uname AS [Instructor Name] 
FROM Enrollment 
JOIN Courses c ON Enrollment.CourseID = c.CourseID
JOIN Users u ON c.InstructorID = u.UserID AND Enrollment.Section = u.Section 
WHERE Enrollment.UserID = 2; 

select * from Users
select * from Enrollment
DELETE FROM Enrollment WHERE UserID =31;  -- Replace 25 with the actual UserID
DELETE FROM Users WHERE UserID = 31;

DELETE FROM Users WHERE UserID BETWEEN 26 AND 30; 

