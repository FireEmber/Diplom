Create Table Discipline 
(
ID int primary key,
Discipline nvarchar(max) not null
)
Create Table [Exercise type]
(
ID int primary key,
[Task type] nvarchar(max) not null
)
Create Table Test 
(
ID int primary key,
TestName nvarchar(max) not null
)
Create Table ExerciseContent 
(
ID int primary key,
Content nvarchar(max) not null
)
Create Table FalseAnswers 
(
ID int primary key,
FalseAnswerOne nvarchar(max) not null,
FalseAnswerTwo nvarchar(max) not null,
FalseAnswerThree nvarchar(max) not null
)
Create Table TrueAnswer 
(
ID int primary key,
TrueAnswer nvarchar(max) not null
)
Create Table Exercise 
(
ID int primary key,
Exercise nvarchar(max) not null,
Discipline int foreign key references Discipline(ID),
[Exercise type] int foreign key references [Exercise type](ID),
Test int foreign key references Test(ID),
ExerciseContent int foreign key references ExerciseContent(ID),
FalseAnswers int foreign key references FalseAnswers(ID),
TrueAnswer int foreign key references TrueAnswer(ID)
)
