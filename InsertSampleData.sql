insert into Levels
values (500), (1000), (2000), (5000), (10000), (20000), (40000), (75000), (125000), (250000), (500000), (1000000);

insert into Questions
values ('An airplanes black box is usually what color?', 1),
('Elephant tusks are made of what material?', 1),
('Excluding wisdom teeth, how many adult teeth do humans have?', 1),
('From whom does the Lutheran Church get its name?', 2),
('How is the Arabic numeral for "2" written?', 2),
('How many $100 bills does it take to equal one million dollars?', 2),
('How many stars are on the European Union flag?', 3),
('Who is called "Heisenberg" in Breaking Bad tv series?', 3),
('What is the result of a mathematical operation 2+2x2', 3),
('What was the name of the supreme god in Norse mythology, father of Thor', 4),
('Who is the author of books related to the fantastic mythology of Middle-earth', 4),
('In computer terminology, what does the acronym "ISP" stand for?', 4),
('In what country did Pokemon originate?', 5),
('Including the bottom, how many sides are on a square-based pyramid?', 5),
('Books by which author tell the story of the witcher Geralt of Rivia', 5),
('People are supposed to drive on the left-hand side of the road in which country?', 6),
('Phoebe, Dione and Helene are moons of what planet?', 6),
('The common term for someone who has difficulty seeing objects in the distance is what?', 6),
('The sport of judo comes from what Asian country?', 7),
('What animal is considered sacred in India?', 7),
('What color is a ruby?', 7),
('"What colors are the two circles in the MasterCard logo?', 8),
('What country is famous for making wooden shoes?', 8),
('What disease is characterized by a bodys inability to properly metabolize glucose?', 8),
('What does a pH level measure?', 9),
('What is a balalaika?', 9),
('What is the approximate speed of light?', 9),
('What is the chemical process wherein a solid is turned to a liquid via the application of heat?', 10),
('What is the colored part of the eye called?', 10),
('What is the correct spelling of New Mexicos largest city?', 10),
('What is the medical term for a doctors identification of a disease?', 11),
('What is the name of Marios brother in the "Super Mario" video games?', 11),
('What is the name of the Newtonian law that states "An object in Motion tends to stay in motion"?', 11),
('Which city is the capital of Scotland?', 12),
('In British currency, how many pence make a pound?', 12),
('In computer terminology, what does the acronym "FTP" stand for?', 12);


insert into Answers 
values ('orange', 1, 1),
('white', 0, 1),
('black', 0, 1),
('purple', 0, 1),

('ivory', 1, 2),
('coral', 0, 2),
('bone', 0, 2),
('calcium', 0, 2),

('28', 1, 3),
('32', 0, 3),
('35', 0, 3),
('40', 0, 3),

('Martin Luther', 1, 4),
('Martin Luther King Jr', 0, 4),
('Luther Vandross', 0, 4),
('Lex Luthor', 0, 4),

('2', 1, 5),
('II', 0, 5),
('I', 0, 5),
('ii', 0, 5),

('ten thousand', 1, 6),
('one thousand', 0, 6),
('one hundred thousand', 0, 6),
('five thousand', 0, 6),

('12', 1, 7),
('14', 0, 7),
('8', 0, 7),
('10', 0, 7),

('Walter White', 1, 8),
('Jesse Pinkman	', 0, 8),
('Hank Schrader', 0, 8),
('Gustavo Fring', 0, 8),

('6', 1, 9),
('8', 0, 9),
('10', 0, 9),
('12', 0, 9),

('Odin', 1, 10),
('Freyr', 0, 10),
('Tyr', 0, 10),
('Baldur', 0, 10),

('John R. R. Tolkien', 1, 11),
('George R. R. Martin', 0, 11),
('Andrzej Sapkowski', 0, 11),
('J. K. Rowling', 0, 11),

('Internet Service Provider', 1, 12),
('Internal Security Position', 0, 12),
('Investment Stability Plan', 0, 12),
('Individual Site Privacy', 0, 12),

('Japan', 1, 13),
('Hungary', 0, 13),
('France', 0, 13),
('Canada', 0, 13),

('five', 1, 14),
('six', 0, 14),
('three', 0, 14),
('four', 0, 14),

('Andrzej Sapkowski', 1, 15),
('George R. R. Martin', 0, 15),
('J.K. Rowling', 0, 15),
('Zygmunt Mi³oszwski', 0, 15),

('England', 1, 16),
('France', 0, 16),
('Italy', 0, 16),
('Germany', 0, 16),

('Saturn', 1, 17),
('Jupiter', 0, 17),
('Neptune', 0, 17),
('Pluto', 0, 17),

('nearsighted', 1, 18),
('farsighted', 0, 18),
('hindsighted', 0, 18),
('hypermetropic', 0, 18),

('Japan', 1, 19),
('Vietnam', 0, 19),
('Laos', 0, 19),
('Philippines', 0, 19),

('cow', 1, 20),
('sheep', 0, 20),
('horse', 0, 20),
('donkey', 0, 20),

('red', 1, 21),
('black', 0, 21),
('yellow', 0, 21),
('blue', 0, 21),

('red and yellow', 1, 22),
('black and white', 0, 22),
('blue and green', 0, 22),
('blue and green', 0, 22),

('The Netherlands', 1, 23),
('Russia', 0, 23),
('Thailand', 0, 23),
('Australia', 0, 23),

('Diabetes', 1, 24),
('Influenza', 0, 24),
('Septicemia', 0, 24),
('Arthritis', 0, 24),

('acidity', 1, 25),
('density', 0, 25),
('wavelength', 0, 25),
('humidity', 0, 25),

('musical instrument', 1, 26),
('Russian peasant', 0, 26),
('type of hat', 0, 26),
('breed of shark', 0, 26),

('300 000 km/s', 1, 27),
('1225 km/h', 0, 27),
('593 000 km/s', 0, 27),
('300 000 km/h', 0, 27),

('melting', 1, 28),
('freezing', 0, 28),
('photosynthesis', 0, 28),
('distillation', 0, 28),

('iris', 1, 29),
('pupil', 0, 29),
('retina', 0, 29),
('cochlea', 0, 29),

('Albuquerque', 1, 30),
('Albuqerque', 0, 30),
('Albequerque', 0, 30),
('Santa Fe', 0, 30),

('Diagnosis', 1, 31),
('Hypnosis', 0, 31),
('Prognosis', 0, 31),
('Trichinosis', 0, 31),

('Luigi', 1, 32),
('Louis', 0, 32),
('Luciano', 0, 32),
('Zelda', 0, 32),

('Law of Inertia', 1, 33),
('Law of Thermodynamics', 0, 33),
('Law of Thermodynamics', 0, 33),
('Law of Gravitation', 0, 33),

('Edinburgh', 1, 34),
('Glasgow', 0, 34),
('Liverpool', 0, 34),
('Birmingham', 0, 34),

('100', 1, 35),
('10', 0, 35),
('500', 0, 35),
('1000', 0, 35),

('file transfer protocol', 1, 36),
('full time portal', 0, 36),
('full text processor', 0, 36),
('free to print', 0, 36);


Select * from Questions q 
inner join Answers a on q.Id = a.QuestionId inner join Levels l on l.Id = q.LevelId