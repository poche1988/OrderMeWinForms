INSERT INTO Users (Username, Password, Name) VALUES ('gonzalo', 'popopo22', 'Gonzalo Amado');
INSERT INTO Users (Username, Password, Name) VALUES ('john', 'louie2007', 'John Niland');
INSERT INTO Users (Username, Password, Name) VALUES ('annelies', 'louie2007', 'Annelies van der Poel');

INSERT INTO Brands (Name) VALUES ('Orijen');
INSERT INTO Brands (Name) VALUES ('Acana');

INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Orijen Puppy', 1);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Large Breed Puppy', 1);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Original', 1);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Senior', 1);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Fit & Trim Dog', 1);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('6 Fish Dog', 1);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Tundra Dog', 1);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Cat & Kitten', 1);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Fit & Trim Cat', 1);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('6 Fish Cat', 1);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Tundra Cat', 1);

INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Puppy Small Breed', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Puppy & Junior', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Puppy Large Breed', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Adult Small Breed', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Cobb Chicken & Greens', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Adult Large Breed', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Senior', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Sport & Agility', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Light & Fit', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Yorkshire Pork', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Grass fed-lamb', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Free Run Duck', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Pacific Pilchard-New', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Wild Prairie Dog', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Pacific Dog', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Grasslands Dog', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Prairie Poultry Dog', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Wild Coast Dog', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Wild Prairie Cat', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Pacific Cat', 2);
INSERT INTO ProductCategories (Name, Brand_BrandId) VALUES ('Grasslands Cat', 2);


INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORPPY.34', '340gm', 1);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORPPY2', '2Kg', 1);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORPPY6', '6Kg', 1);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORPPY11.4', '11.4Kg', 1);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORLBP.34', '340gm', 2);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORLBP6', '6Kg', 2);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORLBP11.4', '11.4Kg', 2);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('OROD.34', '340gm', 3);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('OROD2', '2Kg', 3);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('OROD6', '6Kg', 3);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('OROD11.4', '11.4Kg', 3);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORSNR.34', '340gm', 4);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORSNR2', '2Kg', 4);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORSNR6', '6Kg', 4);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORSNR11.4', '11.4Kg', 4);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORFTD.34', '340gm', 5);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORFTD2', '2Kg', 5);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORFTD6', '6Kg', 5);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORFTD11.4', '11.4Kg', 5);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('OR6F.34', '340gm', 6);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('OR6F2', '2Kg', 6);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('OR6F6', '6Kg', 6);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('OR6F11.4', '11.4Kg', 6);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORTND.34', '340gm', 7);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORTND2', '2Kg', 7);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORTND6', '6Kg', 7);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORTND11.4', '11.4Kg', 7);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORCK.34', '340gm', 8);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORCK1.8', '1.8Kg', 8);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORCK5.4', '5.4Kg', 8);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORFTC.34', '340gm', 9);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORFTC1.8', '1.8Kg', 9);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORFTC5.4', '5.4Kg', 9);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('OR6FC.34', '340gm', 10);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('OR6FC1.8', '1.8Kg', 10);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('OR6FC5.4', '5.4Kg', 10);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORTNC.34', '340gm', 11);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORTNC1.8', '1.8Kg', 11);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ORTNC5.4', '5.4Kg', 11);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACPSB.34', '340gm', 12);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACPSB2', '2Kg', 12);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACPSB6', '6Kg', 12);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACPJ.34', '340gm', 13);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACPJ2', '2Kg', 13);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACPJ6', '6Kg', 13);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACPJ11.4', '11.4Kg', 13);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACPJ17', '17Kg', 13);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACPLB11.4', '11.4Kg', 14);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACPLB17', '17Kg', 14);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACASB.34', '340gm', 15);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACASB2', '2Kg', 15);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACASB6', '6Kg', 15);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACCCG.34', '340gm', 16);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACCCG2', '2Kg', 16);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACCCG6', '6Kg', 16);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACCCG11.4', '11.4Kg', 16);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACCCG17', '17Kg', 16);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACALB11.4', '11.4Kg', 17);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACALB17', '17Kg', 17);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACSE.34', '340gm', 18);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACSE2', '2Kg', 18);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACSE6', '6Kg', 18);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACSE11.4', '11.4Kg', 18);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACS11.4', '11.4Kg', 19);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACS17', '17Kg', 19);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACLF.34', '340gm', 20);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACLF2', '2.27Kg', 20);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACLF6', '6Kg', 20);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACLF11.4', '11.4Kg', 20);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACYP.34', '340gm', 21);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACYP2', '2Kg', 21);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACYP11.4', '11.4Kg', 21);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFL.34', '340gm', 22);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFL2', '2Kg', 22);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFL11.4', '11.4Kg', 22);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACD.34', '340gm', 23);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACD2', '2Kg', 23);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACD11.4', '11.4Kg', 23);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACPP.34', '340gm', 24);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACPP2', '2Kg', 24);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACPP11.4', '11.4Kg', 24);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFW.34', '340gm', 25);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFW2', '2Kg', 25);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFW6', '6Kg', 25);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFW11.4', '11.4Kg', 25);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFP.34', '340gm', 26);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFP2', '2Kg', 26);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFP6', '6Kg', 26);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFP11.4', '11.4Kg', 26);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFG.34', '340gm', 27);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFG2', '2Kg', 27);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFG6', '6Kg', 27);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFG11.4', '11.4Kg', 27);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACCPP.34', '340gm', 28);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACCPP11.4', '11.4Kg', 28);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACCPP17', '17Kg', 28);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACCWC.34', '340gm', 29);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACCWC11.4', '11.4Kg', 29);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACCWC17', '17Kg', 29);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFCW.34', '340gm', 30);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFCW1.8', '1.8Kg', 30);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFCW5.4', '5.4Kg', 30);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFCP.34', '340gm', 31);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFCP1.8', '1.8Kg', 31);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFCP5.4', '5.4Kg', 31);

INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFCG.34', '340gm', 32);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFCG1.8', '1.8Kg', 32);
INSERT INTO Products (SKU, ProductName, Category_ProductCategoryId) VALUES ('ACGFCG5.4', '5.4Kg', 32);

