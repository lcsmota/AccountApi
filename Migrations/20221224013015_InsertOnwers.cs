using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountApi.Migrations
{
    /// <inheritdoc />
    public partial class InsertOnwers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('7fc5c758-f4cb-4ca8-8775-1508e7074674', 'Woodman Cathro', '3/16/1993', '1059 Elmside Park');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('e28137b7-50c0-429e-a5a2-5586655c0fce', 'Cherise Pinn', '12/14/2002', '3 Bartelt Crossing');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('5aae3035-c8ad-48f0-9246-e67481811363', 'Vincenty Worledge', '8/20/2012', '98 Arrowood Junction');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('0312410d-5018-4ef5-884b-9eef0e9eab44', 'Fredra Brizell', '3/14/2009', '890 Forest Run Trail');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('6521caf5-1ba0-45d1-925b-639b61da73ad', 'Minerva Letch', '1/15/2005', '55 Burrows Crossing');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('73ce6048-53d1-42a1-821b-1086fe988eae', 'Tremaine Etheridge', '7/19/1991', '6313 Cody Junction');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('d19bbb82-cf92-4d17-94f4-3969f1db8c25', 'Bathsheba Jiru', '8/7/2006', '609 Hoepker Place');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('8f912d43-c2cb-4024-bef0-b7bad5a73f7b', 'Fair Elford', '4/30/1980', '71155 Loomis Junction');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('0825d257-c293-4796-9e7c-9e35c8da07ad', 'Ralph MacAlpin', '10/27/2003', '75 Shoshone Avenue');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('4edaeef3-6725-4660-b0df-6aa0966149c7', 'Helenelizabeth Denisot', '2/2/2019', '07 Spenser Road');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('23ed4799-f438-4ffc-8a90-d92b0908ddc9', 'Emmanuel Rounsivall', '11/29/2004', '9 Schiller Circle');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('c2af6c10-d8e8-40d5-a916-1f82d2fd0c88', 'Garik Delgadillo', '7/10/2019', '11 Darwin Trail');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('30fcc2b4-0a61-41c4-b6ae-842d55e710f4', 'Thayne Oboy', '2/16/1989', '052 Prentice Park');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('ffd55891-6ee4-4dbe-9401-494e682b8688', 'Hervey Walkington', '7/17/1980', '35 Hauk Circle');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('0f98a02b-d6c0-4fdc-a4d4-e481ee1cec33', 'Tann Atthow', '7/16/2009', '2 Ohio Park');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('6f662261-0be0-4eee-ad24-057c818b3e2e', 'Paula Dorling', '10/10/2009', '752 Hanover Court');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('765b3eb9-0035-49ec-b5dc-33f480993a91', 'Clim Buttrey', '12/6/2009', '4877 Bluestem Road');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('f9d5198f-d2f0-4bc2-98fa-36e56ff71e33', 'Norine Stiant', '2/28/1996', '456 Comanche Center');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('0f5993d1-6f6a-43e5-990e-2a74ab007c6c', 'Zebulen Keneforde', '1/17/2009', '10620 Susan Center');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('b56bfe16-9ffc-4708-8a9a-1546316713dc', 'Dory Kerins', '5/14/1992', '3 Johnson Terrace');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('f74d28b3-8744-45bc-94f1-16c6f9389155', 'Hyacinth Balas', '11/7/2013', '7056 Rieder Court');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('66519324-cb33-4c0d-adc7-70917d18c991', 'Lucina Ellissen', '4/6/2005', '84 Magdeline Point');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('ee74f6ac-bc29-4fab-914d-4c479da9c20c', 'Tito Swithenby', '5/31/2018', '092 Vidon Crossing');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('9b44ab16-abc3-4037-8db6-b91be3b0a79a', 'Bianka Minard', '4/13/1984', '9705 Clarendon Avenue');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('25ed350c-581b-4116-ad8b-c3201fb2c114', 'Klaus Raiment', '10/3/2008', '1992 Fordem Parkway');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('eb66a3eb-fec8-442f-ae3d-ccff593fd34c', 'Alvinia Furphy', '7/6/2012', '8 Burning Wood Circle');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('1064627e-394f-4571-bbfc-f582217f72c9', 'Ario Pirouet', '2/18/2004', '708 Lien Junction');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('82538632-9df6-454b-b040-d8a7e771724a', 'Calv Reoch', '2/20/2007', '8145 Coolidge Alley');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('bafdb7e7-13d4-406b-9a06-431b677362bc', 'Denny Dunbar', '10/7/2016', '46820 Delladonna Court');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('7bcccba8-871f-4476-a4bf-f9f07748d204', 'Lucie Thacker', '3/14/2018', '0 Mcguire Crossing');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('be109b5d-dfad-4b33-9d3a-216f131108a4', 'Lambert Craine', '10/5/2018', '71601 Old Shore Point');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('46bc42d0-f7c4-4795-b310-ac92613f6aff', 'Irma Lightoller', '6/28/1989', '7 Susan Pass');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('7a7c2cb2-f5f5-4bac-b476-91ea187913c8', 'Roarke Bullan', '10/8/1989', '73 Spenser Road');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('bc4fe66e-2a91-48a5-9eae-2867669ed4b2', 'Ilyse Shadrack', '11/12/2022', '65828 Monterey Trail');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('06064da4-e2fd-4248-83cf-47aa27ea4615', 'Quintana Dighton', '4/3/2005', '712 Kensington Terrace');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('94261c61-f293-4566-b7a6-21abe40d8d16', 'Laurena Frantzeni', '8/22/1997', '83436 Chive Park');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('d315f7e0-96c9-4970-b783-0583ab0da524', 'Celene Edger', '3/17/2002', '8303 Paget Crossing');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('50363113-5228-4c7d-b955-33debfab881e', 'Gertrudis Pellant', '10/11/1981', '0 Reinke Point');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('bae364e3-1695-4dbc-99f7-690df63e2322', 'Cy Lippi', '1/11/2021', '19171 Bayside Terrace');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('0dbb0051-555d-4f5c-a42a-5cfb89bf2aa3', 'Veradis Caveney', '6/16/2013', '88944 Bellgrove Lane');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('2d7f2c52-19dd-42cd-8da1-8bb84fbef2dc', 'Waverley Dowsett', '7/17/2022', '4544 Veith Place');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('ea02bea8-1f8d-46c0-8a25-70581f97b3a7', 'Damian Jeacock', '12/7/2018', '6 Reinke Hill');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('0f0f2241-466f-433e-bbce-ec956eeffc7c', 'Betti Abdon', '9/3/2019', '55 Mockingbird Street');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('a141fa3d-756e-4aa8-b5f6-82b6f7940b3a', 'Hestia Werrilow', '3/23/2000', '3 Shelley Junction');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('2425ba67-7ddd-4b5b-bacb-75d8c737f679', 'Kasey Skym', '11/27/2004', '1 Loeprich Point');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('7e2658a9-f5a2-4042-a10f-82a791d12c11', 'Fern Bockings', '1/26/2002', '0 Weeping Birch Crossing');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('772bea4c-e16b-4b3c-a632-1b680bb37f2d', 'Kin Grinyov', '4/19/2009', '44 Hallows Hill');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('d90e2c0d-0f9f-4f06-ae72-b8d456512106', 'Basilius Huzzey', '6/6/2014', '88 Kensington Lane');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('6a281324-a1f5-4132-9132-52f5a5d2b370', 'Gregory Poure', '9/18/1989', '49 Crescent Oaks Lane');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('e84bf793-8a17-4465-8c1a-5d65fb77ae42', 'Tobi Theodore', '10/13/1983', '91915 Petterle Pass');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('0c706819-7525-4249-aa15-fec5f31139af', 'Anastassia Reape', '5/27/1985', '618 Bartelt Park');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('b0ec2811-ff87-487c-864d-638f3ca00e5d', 'Alexandre Pregal', '8/13/1988', '20818 Prairie Rose Junction');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('e6259824-819e-4fec-afaa-03f267d350fd', 'Marianna Dauncey', '6/7/2007', '90873 Dapin Court');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('b9f5de18-c46e-4f34-b431-a590d6c03aca', 'Joey Redler', '11/24/2002', '1 Luster Place');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('f6275add-9fef-4f8c-bee8-ba608e5cb5b7', 'Reese Guinane', '12/11/1993', '05 Vidon Drive');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('df298ee2-5bd9-4a46-8a2a-5d3a885777da', 'Gene Tomkin', '8/31/2014', '720 Mifflin Center');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('787b02ba-eac5-4a23-9718-b43444c41b24', 'Cesare Hightown', '12/2/2020', '5929 Maryland Terrace');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('3afbc9b8-bfaf-45b0-ae36-e55699a3a87f', 'Keri Hudleston', '7/29/2016', '9196 Continental Parkway');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('26af200c-7920-4b7e-bf8b-11fe58713c15', 'Mack Dankov', '6/19/2002', '2215 American Way');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('fbccb93b-af83-471a-8c2c-dcb0e9b18ed8', 'Erwin Rebeiro', '12/27/1980', '14704 Esker Drive');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('adcea544-d0a0-4596-812d-3dcd2477b62f', 'Abbie Lintin', '12/29/2011', '5395 Thompson Plaza');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('188c17af-b495-4671-a28d-a9576b30e535', 'Frasquito Caruth', '3/17/2015', '3690 Raven Park');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('4a412b5e-33a1-4df6-8e62-892a01b16b63', 'Smith Losbie', '5/17/1986', '03560 Esch Terrace');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('7ae00077-a78a-4355-a722-508acc594eef', 'Elvina Gatheridge', '10/13/1985', '834 Stang Center');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('6487dde8-d37e-4b69-b8d4-3287d12f3195', 'Kaycee Arbor', '7/11/1997', '934 Truax Lane');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('eb3cb24e-dd80-43fe-bb1c-4545200cfb52', 'Mureil Charlson', '8/22/2016', '56 Waxwing Center');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('633c77d4-3269-4728-aa3e-6a7d88a3ad8c', 'Theodor Tape', '3/12/1997', '0061 Arrowood Junction');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('7d50aab7-7498-45ff-949c-9247f1e6659d', 'Kleon Copestake', '4/6/1982', '637 Delaware Terrace');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('110c9501-c7b9-4de1-8785-23e39b37dc34', 'Ofella Nettle', '6/16/2001', '4422 Pawling Avenue');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('467d9dc5-7aca-49f2-a2f4-0ef36e23165e', 'Harald Bloxsum', '10/30/1993', '11 East Crossing');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('587e16ec-70b9-47fd-a9ba-1812629008e9', 'Cal Purdie', '7/10/2006', '5 Redwing Center');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('540d3555-0f5e-48ea-b08c-d3004ee2a88a', 'Dilly Linwood', '3/7/1988', '5681 Sunbrook Alley');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('9b1125b3-fe45-4fd5-bd71-71a60d36861c', 'Dynah Cullivan', '9/30/1993', '3 Fuller Plaza');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('d444443b-990e-4339-910d-076a629e0554', 'Gene Ginty', '3/12/1984', '54 Golf Hill');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('c241210d-7c0f-4da5-b10f-f74701d02d22', 'Cori Navarijo', '3/26/2005', '3631 Kedzie Point');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('4cd0d5c1-9129-42b3-9aef-96ce4d0854c8', 'Nikolas Wintle', '3/28/1991', '246 Chive Circle');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('9fc76b34-b1c4-4b20-bb2c-149e7dd62ed6', 'Cly Gartrell', '5/23/2019', '7 Debs Crossing');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('8eefd545-b273-4031-918e-829f893cb9af', 'Nestor Tidbury', '3/19/1996', '829 Dennis Lane');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('eb510fe2-c564-4b5a-888a-a4f4260bb272', 'Shawnee Syers', '6/26/1993', '0 Continental Trail');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('791da84c-496b-4f0f-bae2-38f2d73cb5b6', 'Keefe Tooby', '6/23/2022', '18 Oakridge Alley');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('a3ffcb8d-9231-41fe-ab8a-431f7e430bc4', 'Cory Chrichton', '9/1/2018', '69393 American Ash Crossing');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('c782d2dc-36c7-40db-8687-0c2a6f02c334', 'Tod Sieve', '11/13/2003', '8 Northland Circle');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('162aff0b-15fb-4a7c-b4bf-b9c3c2225d82', 'Marlin Steanson', '1/31/1982', '791 Comanche Alley');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('24007a1e-92df-41bc-8096-be3a9d91611b', 'Gerianne Linge', '6/4/1982', '45 Hansons Lane');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('a78655bf-c073-4497-8a4d-164dada60154', 'Isa Ridhole', '7/31/1996', '2 Old Gate Parkway');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('51c0a9a4-3926-4a03-8ed3-c63e54992785', 'Romy Balaison', '12/18/1999', '511 Oak Valley Court');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('3bea5ab0-9edb-4278-b77a-c8ac51b3669f', 'Ginnifer Doggrell', '4/6/1997', '07942 Hollow Ridge Circle');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('0f1cde3d-3400-40a0-82dc-6131ae5bd254', 'Garret Boullen', '8/7/2001', '953 Waubesa Drive');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('f7f989e5-b47a-4814-bdd1-562a4feb8593', 'Horatia Arrighini', '10/12/2011', '78662 Sage Avenue');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('66649662-b939-46c2-91e5-ce6aee5a653d', 'Sibilla MacGowan', '8/22/1999', '8 Anzinger Point');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('eddba526-d67c-4a89-8538-7c12920b1101', 'Hardy MacKellen', '10/28/2000', '826 Shasta Circle');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('1a6eaaa6-4518-4498-be7e-53cbd7985019', 'Anallise Hallows', '2/24/1981', '2682 Hudson Alley');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('db0355e2-df6b-4480-a090-3d34664be20f', 'Ronny Archer', '5/9/1986', '14611 Forest Dale Pass');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('247f978f-8de1-4745-8f82-04eff1ba7a52', 'Fransisco Swallwell', '3/21/2009', '90446 Pepper Wood Circle');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('12ee2111-7263-4d46-886c-39e0d89f0d7e', 'Tabbitha Hancke', '8/25/2004', '993 Doe Crossing Road');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('d822f3f9-0516-4fda-98ba-75fec3193758', 'Audi Gunn', '8/21/1998', '4486 Carberry Parkway');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('1783421f-9304-4028-bec4-a0ef9e534de0', 'Sigfried Fulun', '5/7/1995', '0 Lien Court');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('a1f1a69f-bc06-4df1-bf19-d5f9efebd983', 'Moria Everett', '8/16/2000', '024 La Follette Road');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('4466c8ff-4363-4494-a917-614bd63da415', 'Adelheid Aves', '11/24/1999', '31 South Crossing');
                                insert into Owners (OwnerId, Name, DateOfBirth, Address) values ('76cd5399-d8ca-4636-b15b-cf6e1e8b798b', 'Elspeth Ricketts', '12/27/1992', '12 Brickson Park Pass');"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Owners");
        }
    }
}
