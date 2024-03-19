-- Users Table
CREATE TABLE Users (
    UserID INT PRIMARY KEY AUTO_INCREMENT,
    Email VARCHAR(255) NOT NULL,
    passwordd VARCHAR(255) NOT NULL,
    UserType ENUM('Instructor', 'Student', 'Administrator') NOT NULL
);

-- Courses Table
CREATE TABLE Courses (
    CourseID INT PRIMARY KEY AUTO_INCREMENT,
    CourseName VARCHAR(255) NOT NULL,
    InstructorID INT,
    FOREIGN KEY (InstructorID) REFERENCES Users(UserID)
);

-- Content Table
CREATE TABLE Assignment (
    AssignmentID INT PRIMARY KEY AUTO_INCREMENT,
    AssignmentName VARCHAR(255) NOT NULL,
    Deadline DATETIME,
	CourseID INT,
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

CREATE TABLE Quiz (
    QuizID INT PRIMARY KEY AUTO_INCREMENT,
	CourseID INT,
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

CREATE TABLE LectureNote (
    LectureNoteID INT PRIMARY KEY AUTO_INCREMENT,
	notes VARCHAR(255),	--uploaded content
	CourseID INT,
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

CREATE TABLE Announcement (
    AnnouncementID INT PRIMARY KEY AUTO_INCREMENT,
	announcements VARCHAR(255),	--uploaded content
	CourseID INT,
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

--CREATE TABLE Content (
  --  ContentID INT PRIMARY KEY AUTO_INCREMENT,
   -- CourseID INT,
    --ContentType ENUM('Announcement', 'LectureNote', 'Assignment', 'Quiz') NOT NULL,
    --ContentPath VARCHAR(255) NOT NULL,
    --Deadline DATETIME,
    --FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
--);

-- Enrollment Table
CREATE TABLE Enrollment (
    EnrollmentID INT PRIMARY KEY AUTO_INCREMENT,
    UserID INT,
    CourseID INT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);
--multiple entries for a student according to course 

-- Bookmarks Table
CREATE TABLE Bookmarks (
    BookmarkID INT PRIMARY KEY AUTO_INCREMENT,
    UserID INT,
    CourseID INT,
	LectureNoteID INT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID),
    FOREIGN KEY (LectureNoteID) REFERENCES LectureNote(LectureNoteID)
);