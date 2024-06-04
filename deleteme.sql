use sommelio;
INSERT INTO Addresses (Id, Street, City, ZipCode, Country, GpsCoordinates) VALUES
(1, 'aaa', 'aaa', '22210', 'aaa', 'aaa');

INSERT INTO ColorsBtn (Id, Name, ColorCode) VALUES
(2, 'black', '0xFF1D1D1B'),
(3, 'orange', '0xFFFFA500'),
(4, 'white', '0xFFFFFFFF'),
(5, 'blue', '0xFF528CD9'),
(6, 'yellow', '0xFFF2B84A'),
(7, 'pink', '0xFFF299B0'),
(8, 'green', '0xFF03A659'),
(9, 'red', '0xFFE94A28');

INSERT INTO Winetypes (Id, Name, ColorId) VALUES
(1, 'Rouge', 9),
(2, 'Rosé', 7),
(3, 'Blanc', 4),
(4, 'other', 5);


INSERT INTO ProfessionalTypes (Id, Name) VALUES
(1, 'Vigneron'),
(2, 'Sommelier'),
(3, 'Caviste');

INSERT INTO FidelityRanks (Id, Name, Milestone) VALUES
(1, 'New', 0),
(2, 'Novice', 1),
(3, 'Apprentice', 2);



INSERT INTO Delicacies (Id, Name, ColorId, parentId) VALUES
(1, 'Viandes', 2, NULL),
(2, 'Poissons', 4, NULL),
(3, 'Végétarien', 8, NULL),
(4, 'other', 6, NULL),
(5, 'Blanche', 4, 1),
(6, 'Rouge', 9, 1),
(7, 'Gibier', 7, 1),
(8, 'Charcuterie', 6, 1),
(9, 'Boeuf', 6, 6),
(10, 'Veau', 5, 6),
(11, 'Porc', 8, 6),
(12, 'Agneau', 9, 6);




INSERT INTO Users (Id, Surname, Email, Password, ProfilePictureUrl, Discriminator, ParticularId, FidelityPoints, FidelityGradeId, QRCode, ProfessionalTypeId, AddressId, Name) VALUES
(3, 'zzzz', 'zzzz', 'df6b9fb15cfdbb7527be5a8a6e39f39e572c8ddb943fbc79a943438e9d3d85ebfc2ccf9e0eccd9346026c0b6876e0e01556fe56f135582c05fbdbb505d46755a', '', 'Professional', '', '', '', '1', '', 'zzzz'),
(5, 'quentin', 'quentin', 'df6b9fb15cfdbb7527be5a8a6e39f39e572c8ddb943fbc79a943438e9d3d85ebfc2ccf9e0eccd9346026c0b6876e0e01556fe56f135582c05fbdbb505d46755a', '', 'Particular', '0', '0', '1', '', '', '', 'quentin'),
(6, 'Guillemand', 'Quentin@toto.com', 'd318d05e058bef0a790241170193757af9691ebf5775cf900b42e20748e509831a62b98a0eb0e4a3f959df3c874ca7a20a2d84efd7e0fc6aa18448c7e27dd210', '', 'Particular', '0', '0', '1', '', '', '', 'Quentin'),
(7, 'Le Pro', 'QentinPro@toto.com', 'd318d05e058bef0a790241170193757af9691ebf5775cf900b42e20748e509831a62b98a0eb0e4a3f959df3c874ca7a20a2d84efd7e0fc6aa18448c7e27dd210', '', 'Professional', '', '', '', '3', '', '', 'QuentinPro'),
(8, 'Marie', 'Mariedodo@toto.com', 'd318d05e058bef0a790241170193757af9691ebf5775cf900b42e20748e509831a62b98a0eb0e4a3f959df3c874ca7a20a2d84efd7e0fc6aa18448c7e27dd210', '', 'Particular', '0', '0', '1', '', '', '', 'Dodo'),
(9, 'Marie', 'Marieeeedodo@toto.com', 'd318d05e058bef0a790241170193757af9691ebf5775cf900b42e20748e509831a62b98a0eb0e4a3f959df3c874ca7a20a2d84efd7e0fc6aa18448c7e27dd210', '', 'Particular', '0', '0', '1', '', '', '', 'Dodo'),
(10, 'Marie', 'Marieeeaaedodo@toto.com', 'd318d05e058bef0a790241170193757af9691ebf5775cf900b42e20748e509831a62b98a0eb0e4a3f959df3c874ca7a20a2d84efd7e0fc6aa18448c7e27dd210', '', 'Particular', '0', '0', '1', '', '', '', 'Dodo'),
(11, 'Paul', 'JaginPaul@toto.com', 'd318d05e058bef0a790241170193757af9691ebf5775cf900b42e20748e509831a62b98a0eb0e4a3f959df3c874ca7a20a2d84efd7e0fc6aa18448c7e27dd210', '', 'Particular', '0', '0', '1', '', '', '', 'Jaguin connard'),
(12, 'Paul', 'JaginPaulito@toto.com', 'd318d05e058bef0a790241170193757af9691ebf5775cf900b42e20748e509831a62b98a0eb0e4a3f959df3c874ca7a20a2d84efd7e0fc6aa18448c7e27dd210', '', 'Particular', '0', '0', '1', '', '', '', 'Jaguin'),
(14, 'Vincent', 'vincGui@toto.com', 'd318d05e058bef0a790241170193757af9691ebf5775cf900b42e20748e509831a62b98a0eb0e4a3f959df3c874ca7a20a2d84efd7e0fc6aa18448c7e27dd210', '', 'Particular', '0', '0', '1', '', '', '', 'Guillemand'),
(15, 'aaaa', 'aaaa', 'd318d05e058bef0a790241170193757af9691ebf5775cf900b42e20748e509831a62b98a0eb0e4a3f959df3c874ca7a20a2d84efd7e0fc6aa18448c7e27dd210', '', 'Particular', '0', '0', '1', '', '', '', 'aaaa'),






INSERT INTO Companies (Id, Userid, AddressId, Name, Description, PictureUrl) VALUES
(1, 2, 1, 'QuentinCompany', 'very good company ', 'aaaa');

INSERT INTO Events (Id, CompanyId, AddressId, Name, Description, PictureUrl, StartDate, EndDate) VALUES
(1, 1, 1, 'palet', 'concour de palet a plemet', 'string', '2024-05-16 22:43:39', '2024-05-16 22:43:39'),
(2, 1, 1, 'La grosse teuf', 'La grosse teuf', 'Evenement1', '2024-05-18 16:10:15', '2024-05-18 16:10:15'),
(3, 1, 1, 'La bagare', 'La bagare', 'Evenement2', '2024-05-18 16:10:15', '2024-05-18 16:10:15');





