PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "AspNetRoles" (
    "Id" TEXT NOT NULL CONSTRAINT "PK_AspNetRoles" PRIMARY KEY,
    "Name" TEXT NULL,
    "NormalizedName" TEXT NULL,
    "ConcurrencyStamp" TEXT NULL,
    "Discriminator" TEXT NOT NULL
);
INSERT INTO AspNetRoles VALUES('9bbc7c4a-481c-4434-b890-44e0686d9820','Admin','ADMIN','4ede6640-3536-4f8a-8361-2afd3f6c68e5','ApplicationRole');
INSERT INTO AspNetRoles VALUES('d49067a8-0b99-4af3-b6bd-085bf8958eef','Guest','GUEST','53a5837e-9e17-4fb0-afbf-2d8dd685e20a','ApplicationRole');
INSERT INTO AspNetRoles VALUES('6562c52b-801f-4a43-a20b-956c4341adc1','Customer','CUSTOMER','6865f42a-66d3-40e0-b7d3-8b6fe7a106aa','ApplicationRole');
CREATE TABLE IF NOT EXISTS "AspNetUsers" (
    "Id" TEXT NOT NULL CONSTRAINT "PK_AspNetUsers" PRIMARY KEY,
    "UserName" TEXT NULL,
    "NormalizedUserName" TEXT NULL,
    "Email" TEXT NULL,
    "NormalizedEmail" TEXT NULL,
    "EmailConfirmed" INTEGER NOT NULL,
    "PasswordHash" TEXT NULL,
    "SecurityStamp" TEXT NULL,
    "ConcurrencyStamp" TEXT NULL,
    "PhoneNumber" TEXT NULL,
    "PhoneNumberConfirmed" INTEGER NOT NULL,
    "TwoFactorEnabled" INTEGER NOT NULL,
    "LockoutEnd" TEXT NULL,
    "LockoutEnabled" INTEGER NOT NULL,
    "AccessFailedCount" INTEGER NOT NULL
);
CREATE TABLE IF NOT EXISTS "Brand" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Brand" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "Name" TEXT NULL,
    "Slug" TEXT NOT NULL,
    "Description" TEXT NULL,
    "Website" TEXT NULL,
    "LogoImage" TEXT NULL
);
INSERT INTO Brand VALUES(1,'2019-11-27 04:26:00.1541277-03:00',0,'Silva, Saraiva and Santos','consequatur-qui-qui','Nam voluptatem voluptatem aut quo rerum voluptatem quibusdam est. Architecto excepturi maxime aspernatur natus laudantium omnis. Corporis et dicta aut alias. Autem error hic quam blanditiis sit beatae ipsa. Cumque non neque.','rafael.com','https://picsum.photos/640/480/?image=143');
INSERT INTO Brand VALUES(2,'2019-11-22 11:48:47.7283005-03:00',0,'Reis e Associados','modi-dolores-nesciunt','Accusantium voluptatibus sunt excepturi et est sed minus.','roberto.biz','https://picsum.photos/640/480/?image=480');
INSERT INTO Brand VALUES(3,'2019-11-07 04:01:42.4493912-03:00',0,'Albuquerque - Melo','ut-rerum-iure','commodi','janaína.name','https://picsum.photos/640/480/?image=470');
INSERT INTO Brand VALUES(4,'2019-11-26 23:41:03.2046361-03:00',0,'Saraiva - Carvalho','quidem-quas-explicabo',replace('Sint cumque tenetur rerum qui unde.\nImpedit autem est non repellat repellendus illo officia ut.\nAccusantium dolorum blanditiis commodi quia officiis deserunt.\nLaudantium qui et et a amet.\nQui sed autem beatae.','\n',char(10)),'gustavo.name','https://picsum.photos/640/480/?image=16');
INSERT INTO Brand VALUES(5,'2019-11-15 16:14:06.1853264-03:00',0,'Moraes - Carvalho','omnis-maiores-et','Doloremque velit aut et nisi dolores et cupiditate mollitia voluptates.','júlio césar.org','https://picsum.photos/640/480/?image=643');
INSERT INTO Brand VALUES(6,'2019-11-25 22:53:27.7844364-03:00',0,'Franco - Carvalho','animi-vero-itaque','Sint minima accusantium et natus ratione. Occaecati doloremque voluptatem eum. Vel sint qui et et ipsam quo aut mollitia occaecati. Et debitis dicta ex laboriosam in vero soluta consequatur.','frederico.biz','https://picsum.photos/640/480/?image=823');
INSERT INTO Brand VALUES(7,'2019-11-15 00:41:58.7942586-03:00',0,'Barros, Carvalho and Carvalho','dolor-id-reprehenderit',replace('Dolorum consequatur nemo qui autem illo voluptatem sed.\nEt occaecati quia natus.\nError necessitatibus et adipisci distinctio voluptatem nobis praesentium suscipit similique.\nSuscipit sed sed.\nAsperiores omnis corporis illum cumque velit numquam.\nAut sed voluptatum quasi quas dolor distinctio nobis enim aperiam.','\n',char(10)),'karla.info','https://picsum.photos/640/480/?image=953');
INSERT INTO Brand VALUES(8,'2019-11-06 19:40:27.067123-03:00',0,'Costa, Oliveira and Santos','qui-cum-ut','libero','pablo.info','https://picsum.photos/640/480/?image=487');
INSERT INTO Brand VALUES(9,'2019-11-13 22:11:23.9825734-03:00',0,'Martins - Costa','laborum-suscipit-sunt','est','márcia.com','https://picsum.photos/640/480/?image=617');
INSERT INTO Brand VALUES(10,'2019-11-04 17:39:23.7929546-03:00',0,'Nogueira, Santos and Braga','amet-quos-ut',replace('Et et assumenda excepturi tenetur esse at.\nOdio maxime rerum optio aperiam numquam mollitia sunt temporibus repellendus.\nNon perspiciatis laboriosam laborum sit asperiores quis natus rerum.\nRem reprehenderit vitae similique unde.\nId sit voluptatem explicabo consequatur.','\n',char(10)),'janaína.br','https://picsum.photos/640/480/?image=947');
INSERT INTO Brand VALUES(11,'2019-11-16 08:05:04.5522323-03:00',0,'Albuquerque LTDA','distinctio-pariatur-commodi','voluptas','alessandro.net','https://picsum.photos/640/480/?image=184');
INSERT INTO Brand VALUES(12,'2019-11-08 12:50:47.8637178-03:00',0,'Silva Comércio','ad-quaerat-sed','Commodi rerum minima rerum et blanditiis. Consequatur at saepe suscipit enim ea perspiciatis quia odit illum. Voluptatem odio sit.','fabiano.info','https://picsum.photos/640/480/?image=600');
INSERT INTO Brand VALUES(13,'2019-11-11 11:34:10.8293994-03:00',0,'Batista - Franco','autem-unde-quasi','Officiis itaque rerum rerum qui minus.','rafael.br','https://picsum.photos/640/480/?image=323');
INSERT INTO Brand VALUES(14,'2019-11-25 01:28:52.8184923-03:00',0,'Xavier - Barros','vel-unde-laborum','ea','ladislau.org','https://picsum.photos/640/480/?image=551');
INSERT INTO Brand VALUES(15,'2019-11-13 02:05:45.7051759-03:00',0,'Carvalho e Associados','reiciendis-nam-excepturi','A voluptatem veritatis et dolorum molestiae aperiam.','larissa.name','https://picsum.photos/640/480/?image=307');
INSERT INTO Brand VALUES(16,'2019-11-23 16:50:14.8343854-03:00',0,'Melo e Associados','in-assumenda-voluptatibus','consequatur','larissa.org','https://picsum.photos/640/480/?image=85');
INSERT INTO Brand VALUES(17,'2019-11-13 05:15:18.4768293-03:00',0,'Batista - Macedo','dolores-commodi-aut',replace('Est nam ratione non nisi necessitatibus illum ducimus.\nAdipisci possimus recusandae sequi odio odio.\nNeque explicabo qui hic fugiat unde.\nDebitis sed odit incidunt neque.\nAmet dolorum sapiente quod rerum occaecati est sint temporibus aperiam.','\n',char(10)),'elísio.net','https://picsum.photos/640/480/?image=945');
INSERT INTO Brand VALUES(18,'2019-11-22 11:16:15.3464792-03:00',0,'Albuquerque, Carvalho and Franco','eaque-perferendis-dicta','Delectus iure velit a quo nobis omnis.','suélen.com','https://picsum.photos/640/480/?image=364');
INSERT INTO Brand VALUES(19,'2019-11-23 22:07:36.5562333-03:00',0,'Barros LTDA','magni-maiores-dolorem','molestiae','rafaela.br','https://picsum.photos/640/480/?image=1046');
INSERT INTO Brand VALUES(20,'2019-11-18 10:23:21.7017249-03:00',0,'Martins S.A.','ad-libero-dolorum','Ut ex nihil magnam nihil dolor quos.','janaína.biz','https://picsum.photos/640/480/?image=452');
INSERT INTO Brand VALUES(21,'2019-11-13 09:31:13.5947096-03:00',0,'Silva S.A.','minima-quo-rerum',replace('Et quo nemo qui et est esse doloremque nostrum porro.\nNulla consequatur eos laborum corporis excepturi.','\n',char(10)),'vitória.name','https://picsum.photos/640/480/?image=396');
INSERT INTO Brand VALUES(22,'2019-11-11 07:29:09.4474411-03:00',0,'Barros e Associados','enim-eum-dolorum','Quibusdam et in incidunt incidunt occaecati similique aspernatur qui. Adipisci nulla illum illum non impedit illum. Ut necessitatibus voluptas sequi earum eos.','talita.biz','https://picsum.photos/640/480/?image=510');
INSERT INTO Brand VALUES(23,'2019-11-24 00:37:20.8578991-03:00',0,'Xavier, Macedo and Albuquerque','ex-delectus-voluptatibus','sed','lucas.br','https://picsum.photos/640/480/?image=811');
INSERT INTO Brand VALUES(24,'2019-11-23 20:19:18.6374118-03:00',0,'Braga - Moraes','totam-velit-non',replace('Ducimus ut cupiditate sed aliquam qui beatae.\nVeritatis nemo in.\nQui incidunt ex quo.','\n',char(10)),'rafael.info','https://picsum.photos/640/480/?image=206');
INSERT INTO Brand VALUES(25,'2019-11-15 12:27:13.7345544-03:00',0,'Barros - Silva','ut-mollitia-quibusdam',replace('Aut quo excepturi.\nNon ut accusamus autem eum distinctio incidunt.\nNeque et et aliquid voluptates maxime dicta harum libero.\nLaborum fuga harum ab.','\n',char(10)),'vitória.name','https://picsum.photos/640/480/?image=107');
INSERT INTO Brand VALUES(26,'2019-11-26 21:03:01.8049765-03:00',0,'Nogueira, Xavier and Reis','consectetur-fugit-eum','dignissimos','esther.biz','https://picsum.photos/640/480/?image=1002');
INSERT INTO Brand VALUES(27,'2019-11-10 00:34:43.6737712-03:00',0,'Braga LTDA','recusandae-unde-et','rerum','marcos.org','https://picsum.photos/640/480/?image=56');
INSERT INTO Brand VALUES(28,'2019-11-15 22:24:00.6935121-03:00',0,'Batista e Associados','eum-voluptas-ducimus','odit','nataniel.net','https://picsum.photos/640/480/?image=226');
INSERT INTO Brand VALUES(29,'2019-11-07 17:45:09.2273051-03:00',0,'Costa Comércio','sapiente-non-vel','velit','paula.com','https://picsum.photos/640/480/?image=36');
INSERT INTO Brand VALUES(30,'2019-11-26 21:45:29.9619092-03:00',0,'Macedo e Associados','molestiae-ad-optio','Cum facilis nisi. Molestiae inventore numquam magni et. Consequatur iure accusamus consequatur perferendis. Fuga incidunt rerum fugit voluptate consequuntur accusantium tenetur vero expedita.','gustavo.com','https://picsum.photos/640/480/?image=499');
INSERT INTO Brand VALUES(31,'2019-11-05 00:40:52.0553941-03:00',0,'Nogueira - Braga','repellendus-esse-laboriosam',replace('Culpa doloribus nisi cumque sed.\nMollitia saepe aut soluta aperiam dolorem sint dolores.\nVelit officiis assumenda veniam.','\n',char(10)),'elísio.org','https://picsum.photos/640/480/?image=48');
INSERT INTO Brand VALUES(32,'2019-11-09 11:42:49.5431153-03:00',0,'Oliveira, Silva and Albuquerque','ratione-ratione-voluptatum','autem','roberto.com','https://picsum.photos/640/480/?image=74');
INSERT INTO Brand VALUES(33,'2019-11-08 23:35:17.358841-03:00',0,'Reis - Franco','ex-non-dolores','Sit aut rerum nihil reiciendis ipsam cumque. Nobis enim quia voluptates itaque libero consequatur. Eveniet voluptatum est atque eaque accusamus eligendi provident. Dolores voluptatum soluta est et debitis culpa magni. Non eos dolorem cupiditate voluptatibus dignissimos animi a. Doloremque dignissimos officia voluptatem sit quae.','césar.info','https://picsum.photos/640/480/?image=21');
INSERT INTO Brand VALUES(34,'2019-11-06 01:02:23.1969829-03:00',0,'Nogueira S.A.','voluptatum-dolor-eligendi','Sit itaque eius et dolore qui rerum soluta suscipit officia.','hélio.name','https://picsum.photos/640/480/?image=369');
INSERT INTO Brand VALUES(35,'2019-11-17 14:06:50.3052943-03:00',0,'Moreira - Carvalho','alias-mollitia-eveniet',replace('Dolor ea aperiam non.\nDoloremque accusamus aspernatur adipisci totam at labore amet.\nConsequatur sed sed culpa dolorem omnis odio.\nConsequatur aperiam voluptates in omnis vero facere impedit voluptates illo.','\n',char(10)),'célia.com','https://picsum.photos/640/480/?image=898');
INSERT INTO Brand VALUES(36,'2019-11-26 01:29:00.9603017-03:00',0,'Moreira e Associados','earum-enim-modi','aspernatur','célia.biz','https://picsum.photos/640/480/?image=37');
INSERT INTO Brand VALUES(37,'2019-11-06 05:15:35.8818381-03:00',0,'Silva e Associados','deleniti-libero-voluptatem','Rerum rerum et dolorem nisi fuga expedita at rem facere.','júlio.biz','https://picsum.photos/640/480/?image=93');
INSERT INTO Brand VALUES(38,'2019-11-20 07:14:21.3933984-03:00',0,'Franco e Associados','eligendi-ut-neque','Labore neque velit non rerum accusantium debitis veritatis aliquam. Consectetur corporis dolores impedit hic vitae. Adipisci dolorum ipsa adipisci quo voluptatem dignissimos ea. Ut eos natus dolor quisquam. Nulla aut sed illo quasi.','feliciano.net','https://picsum.photos/640/480/?image=58');
INSERT INTO Brand VALUES(39,'2019-11-19 20:33:02.7290262-03:00',0,'Batista, Batista and Batista','et-dignissimos-adipisci','Necessitatibus odit accusantium ex sit ex deleniti voluptas cupiditate facilis. Libero enim aut sit rerum soluta et occaecati. Consequatur sint temporibus eaque corporis nihil omnis at tempore. Numquam numquam in dolores illo. Quis neque quisquam quia exercitationem sint accusamus optio doloremque sapiente.','fabiano.com','https://picsum.photos/640/480/?image=371');
INSERT INTO Brand VALUES(40,'2019-11-06 02:34:58.261646-03:00',0,'Souza - Saraiva','doloribus-modi-sequi','Distinctio molestias nulla ad aliquid rem quasi facere. Repellendus quaerat nam tempore accusantium eum inventore. Ut nobis optio quo.','roberta.biz','https://picsum.photos/640/480/?image=201');
INSERT INTO Brand VALUES(41,'2019-11-09 23:16:55.7472211-03:00',0,'Moraes LTDA','repellat-voluptas-quisquam','Fugit voluptates culpa sit. Distinctio voluptatum voluptatibus quo. Voluptates fuga est ut consequatur vel dolorem. Itaque accusamus aperiam omnis qui sed velit ad vel.','alexandre.info','https://picsum.photos/640/480/?image=443');
INSERT INTO Brand VALUES(42,'2019-11-26 07:28:37.3518208-03:00',0,'Franco e Associados','fuga-aut-sed','dolor','janaína.br','https://picsum.photos/640/480/?image=88');
INSERT INTO Brand VALUES(43,'2019-11-21 19:10:58.8109527-03:00',0,'Braga - Nogueira','est-eos-earum','Ipsa illum magni suscipit quibusdam. Quas qui itaque enim illo sunt quae dolor ut quo. Dignissimos sit eum doloribus. Repudiandae et in deleniti qui in possimus. Qui at sed autem.','pablo.br','https://picsum.photos/640/480/?image=586');
INSERT INTO Brand VALUES(44,'2019-11-25 15:51:50.2188715-03:00',0,'Oliveira S.A.','voluptatum-est-quod',replace('Quia itaque sed ullam autem est facere.\nEt enim non rerum fugiat asperiores et molestiae.\nEst dolores molestiae impedit enim quam sed culpa.\nUt officia libero vero doloribus mollitia repudiandae fugit aliquid.\nLaborum quos occaecati dolor omnis quaerat ducimus voluptatem asperiores vitae.','\n',char(10)),'sílvia.name','https://picsum.photos/640/480/?image=330');
INSERT INTO Brand VALUES(45,'2019-11-11 13:16:12.4641045-03:00',0,'Santos Comércio','quam-quos-in','Ab minima aliquam voluptas.','mércia.biz','https://picsum.photos/640/480/?image=222');
INSERT INTO Brand VALUES(46,'2019-11-05 11:40:41.5625419-03:00',0,'Moraes - Albuquerque','maiores-magni-et','facere','nataniel.biz','https://picsum.photos/640/480/?image=312');
INSERT INTO Brand VALUES(47,'2019-11-05 01:53:16.6451104-03:00',0,'Martins, Albuquerque and Moreira','quo-tempora-odio',replace('Magnam sunt tempore nisi.\nOmnis itaque sint numquam quia ut ut tempore sit dicta.\nDolores magni quo et et.','\n',char(10)),'feliciano.org','https://picsum.photos/640/480/?image=112');
INSERT INTO Brand VALUES(48,'2019-11-20 03:51:25.3912515-03:00',0,'Souza - Silva','odit-quia-aliquid','Qui unde exercitationem.','alessandra.biz','https://picsum.photos/640/480/?image=98');
INSERT INTO Brand VALUES(49,'2019-11-25 13:54:40.8012808-03:00',0,'Franco - Nogueira','ipsam-ut-ea','alias','talita.info','https://picsum.photos/640/480/?image=440');
INSERT INTO Brand VALUES(50,'2019-11-13 07:31:16.1802431-03:00',0,'Saraiva - Barros','et-a-possimus','Vero quod deleniti dolores. Illum et id quasi eveniet sequi quasi. Iure culpa earum voluptatem enim laudantium exercitationem aspernatur ratione.','silas.org','https://picsum.photos/640/480/?image=208');
INSERT INTO Brand VALUES(51,'2019-11-18 01:56:33.0377538-03:00',0,'Reis Comércio','expedita-ipsam-aspernatur','Atque sint cumque earum.','bruna.br','https://picsum.photos/640/480/?image=653');
INSERT INTO Brand VALUES(52,'2019-11-20 07:55:18.664467-03:00',0,'Costa e Associados','tempora-maxime-id','Qui voluptatem fuga id. Dolore laboriosam ut quidem earum corporis. Quod qui cupiditate. Reiciendis esse exercitationem possimus hic non quam provident. Voluptatem enim est quia voluptatem ut totam.','alexandre.br','https://picsum.photos/640/480/?image=69');
INSERT INTO Brand VALUES(53,'2019-11-22 13:06:17.9045438-03:00',0,'Moreira - Costa','molestias-quo-facilis','corrupti','yuri.biz','https://picsum.photos/640/480/?image=298');
INSERT INTO Brand VALUES(54,'2019-11-24 05:46:24.1307536-03:00',0,'Pereira, Xavier and Franco','occaecati-veritatis-libero','Accusamus et repellat harum perspiciatis. In alias quidem minus corrupti. Expedita et minus sapiente voluptatem. Maiores laudantium dignissimos.','deneval.com','https://picsum.photos/640/480/?image=540');
INSERT INTO Brand VALUES(55,'2019-11-05 04:09:41.4981898-03:00',0,'Moraes, Moreira and Saraiva','fugiat-odio-soluta','Sint officiis tempora eius quidem sunt amet dolor facere.','félix.name','https://picsum.photos/640/480/?image=748');
INSERT INTO Brand VALUES(56,'2019-11-08 11:53:58.2150435-03:00',0,'Franco S.A.','quas-nisi-dolor','nihil','ígor.net','https://picsum.photos/640/480/?image=1067');
INSERT INTO Brand VALUES(57,'2019-11-13 03:23:45.9331072-03:00',0,'Melo - Moreira','sit-a-rerum','voluptas','mércia.com','https://picsum.photos/640/480/?image=557');
INSERT INTO Brand VALUES(58,'2019-11-07 03:00:35.3900844-03:00',0,'Carvalho - Melo','aperiam-vitae-praesentium','sit','ofélia.net','https://picsum.photos/640/480/?image=254');
INSERT INTO Brand VALUES(59,'2019-11-19 10:46:59.4890919-03:00',0,'Carvalho, Franco and Moreira','eos-placeat-repellat','Quos rerum enim veniam veritatis voluptatem tempore commodi. Qui ipsum quidem est inventore quae. Debitis odit ab alias facere incidunt et. Dolorem ab eos distinctio sit et aperiam quisquam nihil qui. Vel expedita reprehenderit earum et.','yuri.br','https://picsum.photos/640/480/?image=36');
INSERT INTO Brand VALUES(60,'2019-11-08 09:22:28.4142164-03:00',0,'Pereira, Carvalho and Melo','consequatur-quod-unde','Et quod delectus numquam temporibus. Nihil et sapiente et a dolorem assumenda. Cum et quae. Id sint ut alias explicabo optio omnis dignissimos quia. Nihil earum atque et. Quisquam debitis dignissimos quas labore architecto vel quam.','fabrícia.com','https://picsum.photos/640/480/?image=483');
CREATE TABLE IF NOT EXISTS "Category" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Category" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "Name" TEXT NOT NULL,
    "Slug" TEXT NOT NULL,
    "Description" TEXT NOT NULL,
    "DisplayOrder" INTEGER NOT NULL,
    "IsPublished" INTEGER NOT NULL,
    "IncludeInMenu" INTEGER NOT NULL,
    "ParentId" INTEGER NULL,
    "ChildrenId" INTEGER NULL,
    "ThumbnailImageUrl" TEXT NULL
);
INSERT INTO Category VALUES(1,'2019-11-06 19:31:37.9717571-03:00',0,'Home','quia-recusandae-eos','Itaque reprehenderit dicta non esse inventore a et voluptas est. Quis odit modi ad. Sed deserunt corrupti sit rerum porro dignissimos quibusdam ipsa. Esse voluptatibus debitis at explicabo. Harum numquam non iusto quia sed. Nobis corporis minima rerum distinctio vitae molestiae aliquid illum.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(2,'2019-11-21 01:15:33.6459892-03:00',0,'Kids','nihil-animi-cum','Necessitatibus facilis magni placeat nam.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(3,'2019-11-15 04:04:44.9139937-03:00',0,'Grocery','dignissimos-placeat-sint',replace('Est ut qui est voluptas vel eos optio voluptatem.\nExercitationem qui modi non debitis dolor maiores.\nQuisquam eveniet fugiat accusantium.\nEst vero est qui et qui fugiat expedita similique.\nAut mollitia dicta at qui consequuntur.','\n',char(10)),0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(4,'2019-11-18 15:08:28.4467689-03:00',0,'Automotive','saepe-quia-dolorem','nihil',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(5,'2019-11-11 21:37:04.821208-03:00',0,'Electronics','enim-in-nam','maxime',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(6,'2019-11-09 05:47:02.5578411-03:00',0,'Toys','in-repudiandae-magnam','Impedit enim voluptatem in vero quisquam soluta tempora ipsum. Sed id aut accusamus dolorem libero alias odio ut. Qui sunt quas qui quo sed rerum et.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(7,'2019-11-14 17:50:58.1030209-03:00',0,'Electronics','temporibus-accusantium-deserunt','et',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(8,'2019-11-26 11:50:34.6422242-03:00',0,'Garden','accusamus-nihil-tenetur','Ut aut doloribus illum praesentium et sunt. Voluptatum id dolorem ea fugit reprehenderit ea aut. Aut fuga soluta id quisquam molestiae adipisci dolorum. Error facilis sed rerum quia nihil quibusdam sit voluptatem aut. Accusamus soluta nihil omnis quibusdam ut.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(9,'2019-11-05 23:44:44.739197-03:00',0,'Music','quia-consequuntur-numquam',replace('Consequuntur nobis est exercitationem laudantium eum.\nFugit ratione velit quisquam laboriosam explicabo omnis aspernatur cum.\nOdit ut fugit voluptatem qui ut aut iste placeat sequi.','\n',char(10)),0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(10,'2019-11-14 01:43:09.7624519-03:00',0,'Automotive','eos-dolorem-et','Aut neque magnam odit aut inventore voluptatum expedita et. Ad praesentium totam explicabo dicta consequatur sint quam rerum dolorem. Eos quam qui esse. Laborum rem est reiciendis. Qui amet sunt ex quo. Mollitia natus eveniet sunt.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(11,'2019-11-17 09:56:34.2343789-03:00',0,'Games','odit-omnis-sit','temporibus',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(12,'2019-11-19 12:54:22.6192928-03:00',0,'Garden','hic-facilis-nulla',replace('Dicta non consequatur.\nNeque omnis voluptas nobis ea.\nFacilis est vero temporibus et.\nRepellat ipsa et est quisquam quo ut.\nNatus reprehenderit dignissimos.','\n',char(10)),0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(13,'2019-11-26 11:24:50.6011795-03:00',0,'Games','vel-iste-quod','Nihil et eaque consequatur.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(14,'2019-11-21 00:47:15.3806122-03:00',0,'Garden','facere-vitae-architecto','rerum',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(15,'2019-11-05 03:30:38.8748861-03:00',0,'Movies','esse-et-nisi',replace('Tempora nisi mollitia ratione omnis velit.\nUnde qui adipisci minima.\nVeniam consequatur sit similique consequuntur velit iure rerum quis.\nSaepe autem facilis.\nEligendi atque est a.\nOptio impedit distinctio.','\n',char(10)),0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(16,'2019-11-23 18:22:13.9599088-03:00',0,'Clothing','perspiciatis-omnis-id','Iste culpa necessitatibus aperiam suscipit ut.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(17,'2019-11-22 21:40:53.8598744-03:00',0,'Health','omnis-sapiente-consequuntur','aut',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(18,'2019-11-23 20:17:51.4504374-03:00',0,'Shoes','autem-sed-ad','Eos ut iste unde ea et et quis nemo.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(19,'2019-11-06 02:33:19.3321681-03:00',0,'Computers','et-inventore-iusto','Voluptatem consequuntur odio numquam dicta et natus nam. Iure quia minima maxime eos culpa mollitia quia. Alias dolorum velit excepturi pariatur quia. Iste et et facere repellat adipisci eveniet et consequatur ratione.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(20,'2019-11-25 11:16:03.3182501-03:00',0,'Electronics','sed-rerum-voluptas','Aut molestiae autem aut nihil sint vel nisi voluptatem. Asperiores quisquam id. Explicabo ut sint ducimus rerum voluptates saepe quia. Culpa nostrum qui.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(21,'2019-11-27 16:44:06.1612547-03:00',0,'Health','in-dolorem-omnis','totam',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(22,'2019-11-13 16:55:13.8862619-03:00',0,'Games','sed-et-totam','consequatur',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(23,'2019-11-13 16:42:11.1179079-03:00',0,'Toys','at-nisi-ut','Alias ut provident qui. Ad culpa velit voluptate possimus quas ut. Temporibus asperiores distinctio aperiam incidunt. Placeat sed reiciendis veritatis dolorem dolores veritatis.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(24,'2019-11-21 01:01:12.7319795-03:00',0,'Automotive','eos-ut-inventore','Nobis ut ut consequatur est excepturi commodi molestiae asperiores totam. Delectus maxime adipisci qui culpa beatae doloremque facilis sed dolore. Ratione quod rerum nihil doloremque. Quos molestias maxime odio est commodi aliquid consequatur.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(25,'2019-11-08 23:12:16.6617229-03:00',0,'Movies','quia-sit-quisquam','Quam occaecati vel iure mollitia vitae quisquam.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(26,'2019-11-26 22:13:39.7580225-03:00',0,'Music','rerum-amet-facilis','Ipsum voluptates consectetur qui adipisci cupiditate laborum saepe ipsa fugit. Qui nihil tempore odio dicta qui rerum error. Quas magni quod. Qui officia placeat dolor qui eos aut quam aliquid.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(27,'2019-11-17 11:58:11.2856822-03:00',0,'Tools','et-similique-perspiciatis','Nemo ipsa quidem eveniet sunt numquam illo sed.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(28,'2019-11-14 07:29:15.6198431-03:00',0,'Movies','recusandae-ad-quis','odit',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(29,'2019-11-17 19:35:15.5078926-03:00',0,'Computers','ut-neque-ut','Veniam ducimus adipisci. Quibusdam perferendis in et possimus ut. Recusandae iure non repellat ipsa tempora repellendus. Quia numquam possimus. Voluptatum quibusdam beatae eligendi sint.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(30,'2019-11-22 17:33:07.8904866-03:00',0,'Clothing','numquam-inventore-suscipit',replace('Omnis iure expedita voluptas nihil ipsa iure ut.\nPerspiciatis animi doloribus.\nEt libero quae distinctio maiores ipsum cupiditate quo.\nEveniet consequatur ut dolor non.\nEst numquam voluptas et ut modi est ea omnis.\nItaque iste suscipit.','\n',char(10)),0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(31,'2019-11-06 07:06:56.152838-03:00',0,'Beauty','numquam-quae-nam','Et et quos.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(32,'2019-11-06 03:13:36.8131579-03:00',0,'Toys','eveniet-qui-tempora','nostrum',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(33,'2019-11-06 05:57:18.9806575-03:00',0,'Automotive','officiis-fugiat-sunt',replace('Aspernatur soluta vitae ducimus voluptas.\nHic vel modi et.\nVoluptatem fugiat voluptatem possimus.\nOfficiis ut est ullam quis eveniet.','\n',char(10)),0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(34,'2019-11-27 12:51:40.7881994-03:00',0,'Music','explicabo-nisi-suscipit','esse',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(35,'2019-11-25 15:19:36.2753238-03:00',0,'Jewelery','quo-ipsam-consectetur','Voluptatum beatae quasi distinctio nihil expedita doloremque sed. Eos ducimus perferendis maxime aliquam cupiditate. Ut quasi labore. Hic natus sint fugit eum quo qui consequuntur. Consequatur unde tempore aut ab soluta suscipit tempore maxime a. Blanditiis ut hic non ab.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(36,'2019-11-22 01:22:48.9548875-03:00',0,'Clothing','exercitationem-enim-unde','laborum',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(37,'2019-11-13 09:27:13.5990012-03:00',0,'Industrial','perspiciatis-exercitationem-enim','Omnis ut in qui aut odit minima.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(38,'2019-11-07 07:39:51.0985196-03:00',0,'Clothing','voluptatem-laborum-id','Provident error occaecati.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(39,'2019-11-08 08:19:21.5556733-03:00',0,'Home','fugiat-voluptatibus-qui','magni',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(40,'2019-11-18 20:05:27.3437367-03:00',0,'Books','sed-nostrum-aut','voluptatem',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(41,'2019-11-20 06:04:38.5260627-03:00',0,'Shoes','debitis-hic-ducimus','ipsa',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(42,'2019-11-07 17:25:17.1110131-03:00',0,'Computers','est-nihil-dolore','beatae',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(43,'2019-11-15 02:58:11.7851775-03:00',0,'Health','nemo-beatae-consequuntur','Asperiores illum ipsum deleniti doloribus dolor. Vel voluptates commodi nulla magnam accusantium sint. Labore hic itaque aliquid aliquam nisi dignissimos esse. Ea delectus et id soluta placeat voluptates. Non quia maxime fugit. Occaecati temporibus eveniet impedit magnam vero.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(44,'2019-11-05 08:26:46.8913266-03:00',0,'Movies','quia-accusamus-libero','sunt',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(45,'2019-11-05 17:40:26.5140647-03:00',0,'Tools','rerum-et-nulla',replace('Quaerat et et.\nNumquam aspernatur delectus unde non quidem optio saepe accusamus et.\nSuscipit facilis voluptatum quod qui libero dolorem nemo.\nQuia maiores eaque ipsa.\nIn eaque non quia omnis.','\n',char(10)),0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(46,'2019-11-14 13:05:21.578276-03:00',0,'Movies','debitis-ducimus-facilis',replace('Necessitatibus minus rerum blanditiis saepe tempora id est rerum aut.\nSit odit aliquam qui.','\n',char(10)),0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(47,'2019-11-27 19:45:41.0416197-03:00',0,'Clothing','quaerat-placeat-et',replace('Natus aperiam non reiciendis.\nDebitis qui adipisci temporibus labore optio voluptas.','\n',char(10)),0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(48,'2019-11-21 07:15:37.1531771-03:00',0,'Movies','doloribus-molestiae-neque',replace('Qui at sequi doloremque et.\nAnimi nesciunt tempora ut tempora qui atque vel.','\n',char(10)),0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(49,'2019-11-13 13:26:25.8845352-03:00',0,'Electronics','deleniti-quasi-consequatur','magnam',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(50,'2019-11-20 05:42:45.3675545-03:00',0,'Baby','eveniet-provident-cum',replace('Eos voluptatem iure expedita animi.\nCorrupti voluptas est voluptatem aut ut.\nAnimi ea non nulla architecto earum nisi ad ipsa amet.','\n',char(10)),0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(51,'2019-11-16 17:41:30.1346546-03:00',0,'Baby','vero-numquam-ea',replace('Magni et eius quae porro repudiandae laborum dolorum.\nQui ipsum quia nemo unde.','\n',char(10)),0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(52,'2019-11-10 08:10:54.4620571-03:00',0,'Health','facilis-tempore-ea','rerum',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(53,'2019-11-28 10:53:40.0406498-03:00',0,'Electronics','similique-et-harum',replace('Soluta tempore et error enim et velit quia.\nIn commodi in inventore.\nAut soluta occaecati.','\n',char(10)),0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(54,'2019-11-14 18:00:53.9104689-03:00',0,'Garden','officia-iusto-explicabo','doloremque',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(55,'2019-11-21 16:18:43.9876445-03:00',0,'Games','et-quia-accusamus',replace('Quia rerum corporis qui quam molestiae accusamus labore.\nFacere quos rerum quisquam aliquid.','\n',char(10)),0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(56,'2019-11-14 13:32:36.8572744-03:00',0,'Kids','soluta-vero-eaque','Et repellendus laudantium voluptate quos sit aut.',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(57,'2019-11-24 09:30:50.6022693-03:00',0,'Sports','sit-sit-aut',replace('Veritatis esse expedita facilis voluptate maxime.\nRecusandae labore asperiores.\nVoluptate asperiores error natus deleniti cum perspiciatis optio.\nDolorum nulla similique.\nUt et explicabo.','\n',char(10)),0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(58,'2019-11-17 23:58:28.1479917-03:00',0,'Games','architecto-eaque-est','consequuntur',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(59,'2019-11-07 08:07:35.0137207-03:00',0,'Music','libero-tenetur-et','itaque',0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
INSERT INTO Category VALUES(60,'2019-11-13 11:07:28.7321038-03:00',0,'Clothing','dolorum-voluptatem-tenetur',replace('Iure dignissimos aliquam.\nIllum ut ut aut.\nSimilique et excepturi harum odit aut iure eos.','\n',char(10)),0,1,1,NULL,NULL,'http://lorempixel.com/640/480/fashion');
CREATE TABLE IF NOT EXISTS "EntityType" (
    "Id" TEXT NOT NULL CONSTRAINT "PK_EntityType" PRIMARY KEY,
    "IsMenuable" INTEGER NOT NULL,
    "AreaName" TEXT NULL,
    "RoutingController" TEXT NULL,
    "RoutingAction" TEXT NULL,
    "IsDeleted" INTEGER NOT NULL
);
CREATE TABLE IF NOT EXISTS "Media" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Media" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "Caption" TEXT NULL,
    "FileSize" INTEGER NOT NULL,
    "FileName" TEXT NULL,
    "MediaType" INTEGER NOT NULL,
    "SeoFileName" TEXT NULL
);
INSERT INTO Media VALUES(1,'2019-11-28 15:38:37.5537324+00:00',0,NULL,281,'https://loremflickr.com/320/240?lock=789837287',1,NULL);
INSERT INTO Media VALUES(2,'2019-11-28 15:38:37.4835135+00:00',0,NULL,599,'https://loremflickr.com/320/240?lock=442784934',1,NULL);
INSERT INTO Media VALUES(3,'2019-11-28 15:38:37.2722392+00:00',0,NULL,330,'https://loremflickr.com/320/240?lock=1116065776',1,NULL);
INSERT INTO Media VALUES(4,'2019-11-28 15:38:37.412777+00:00',0,NULL,89,'https://loremflickr.com/320/240?lock=1493899283',1,NULL);
INSERT INTO Media VALUES(5,'2019-11-28 15:38:37.7186595+00:00',0,NULL,449,'https://loremflickr.com/320/240?lock=1297445797',1,NULL);
INSERT INTO Media VALUES(6,'2019-11-28 15:38:37.3420306+00:00',0,NULL,416,'https://loremflickr.com/320/240?lock=780156191',1,NULL);
INSERT INTO Media VALUES(7,'2019-11-28 15:38:37.6325478+00:00',0,NULL,280,'https://loremflickr.com/320/240?lock=1507173110',1,NULL);
INSERT INTO Media VALUES(8,'2019-11-28 15:38:37.2047559+00:00',0,NULL,445,'https://loremflickr.com/320/240?lock=292040783',1,NULL);
INSERT INTO Media VALUES(9,'2019-11-28 15:38:37.1361804+00:00',0,NULL,959,'https://loremflickr.com/320/240?lock=1378132273',1,NULL);
INSERT INTO Media VALUES(10,'2019-11-28 15:38:37.0456255+00:00',0,NULL,971,'https://loremflickr.com/320/240?lock=2036792554',1,NULL);
INSERT INTO Media VALUES(11,'2019-11-28 15:38:39.0950553+00:00',0,NULL,884,'https://loremflickr.com/320/240?lock=294819658',1,NULL);
INSERT INTO Media VALUES(12,'2019-11-28 15:38:39.3560753+00:00',0,NULL,542,'https://loremflickr.com/320/240?lock=526700554',1,NULL);
INSERT INTO Media VALUES(13,'2019-11-28 15:38:39.2716048+00:00',0,NULL,573,'https://loremflickr.com/320/240?lock=1789562919',1,NULL);
INSERT INTO Media VALUES(14,'2019-11-28 15:38:39.1864792+00:00',0,NULL,567,'https://loremflickr.com/320/240?lock=2097843888',1,NULL);
INSERT INTO Media VALUES(15,'2019-11-28 15:38:39.238023+00:00',0,NULL,912,'https://loremflickr.com/320/240?lock=977543191',1,NULL);
INSERT INTO Media VALUES(16,'2019-11-28 15:38:39.1488815+00:00',0,NULL,525,'https://loremflickr.com/320/240?lock=955404718',1,NULL);
INSERT INTO Media VALUES(17,'2019-11-28 15:38:39.2886334+00:00',0,NULL,576,'https://loremflickr.com/320/240?lock=1618955930',1,NULL);
INSERT INTO Media VALUES(18,'2019-11-28 15:38:39.2038808+00:00',0,NULL,938,'https://loremflickr.com/320/240?lock=810126343',1,NULL);
INSERT INTO Media VALUES(19,'2019-11-28 15:38:39.3390516+00:00',0,NULL,961,'https://loremflickr.com/320/240?lock=211421815',1,NULL);
INSERT INTO Media VALUES(20,'2019-11-28 15:38:39.2207346+00:00',0,NULL,771,'https://loremflickr.com/320/240?lock=2105510778',1,NULL);
INSERT INTO Media VALUES(21,'2019-11-28 15:38:39.1126148+00:00',0,NULL,586,'https://loremflickr.com/320/240?lock=1598394363',1,NULL);
INSERT INTO Media VALUES(22,'2019-11-28 15:38:39.3223535+00:00',0,NULL,839,'https://loremflickr.com/320/240?lock=1669592440',1,NULL);
INSERT INTO Media VALUES(23,'2019-11-28 15:38:39.2548229+00:00',0,NULL,147,'https://loremflickr.com/320/240?lock=117470872',1,NULL);
INSERT INTO Media VALUES(24,'2019-11-28 15:38:39.1305638+00:00',0,NULL,483,'https://loremflickr.com/320/240?lock=249958107',1,NULL);
INSERT INTO Media VALUES(25,'2019-11-28 15:38:39.3901042+00:00',0,NULL,166,'https://loremflickr.com/320/240?lock=1635453159',1,NULL);
INSERT INTO Media VALUES(26,'2019-11-28 15:38:39.0773506+00:00',0,NULL,593,'https://loremflickr.com/320/240?lock=189783194',1,NULL);
INSERT INTO Media VALUES(27,'2019-11-28 15:38:39.4242306+00:00',0,NULL,273,'https://loremflickr.com/320/240?lock=1651783749',1,NULL);
INSERT INTO Media VALUES(28,'2019-11-28 15:38:38.7890416+00:00',0,NULL,258,'https://loremflickr.com/320/240?lock=1293562810',1,NULL);
INSERT INTO Media VALUES(29,'2019-11-28 15:38:38.7722043+00:00',0,NULL,597,'https://loremflickr.com/320/240?lock=1350562454',1,NULL);
INSERT INTO Media VALUES(30,'2019-11-28 15:38:38.7553611+00:00',0,NULL,463,'https://loremflickr.com/320/240?lock=292204196',1,NULL);
INSERT INTO Media VALUES(31,'2019-11-28 15:38:38.7384383+00:00',0,NULL,379,'https://loremflickr.com/320/240?lock=2034038963',1,NULL);
INSERT INTO Media VALUES(32,'2019-11-28 15:38:39.4411783+00:00',0,NULL,136,'https://loremflickr.com/320/240?lock=1719047620',1,NULL);
INSERT INTO Media VALUES(33,'2019-11-28 15:38:38.7214749+00:00',0,NULL,138,'https://loremflickr.com/320/240?lock=526828262',1,NULL);
INSERT INTO Media VALUES(34,'2019-11-28 15:38:38.7028307+00:00',0,NULL,204,'https://loremflickr.com/320/240?lock=1771110393',1,NULL);
INSERT INTO Media VALUES(35,'2019-11-28 15:38:38.685504+00:00',0,NULL,378,'https://loremflickr.com/320/240?lock=489386387',1,NULL);
INSERT INTO Media VALUES(36,'2019-11-28 15:38:38.6683761+00:00',0,NULL,666,'https://loremflickr.com/320/240?lock=174307641',1,NULL);
INSERT INTO Media VALUES(37,'2019-11-28 15:38:39.4579873+00:00',0,NULL,625,'https://loremflickr.com/320/240?lock=404702642',1,NULL);
INSERT INTO Media VALUES(38,'2019-11-28 15:38:38.6509991+00:00',0,NULL,193,'https://loremflickr.com/320/240?lock=84397380',1,NULL);
INSERT INTO Media VALUES(39,'2019-11-28 15:38:38.6334103+00:00',0,NULL,911,'https://loremflickr.com/320/240?lock=1376552094',1,NULL);
INSERT INTO Media VALUES(40,'2019-11-28 15:38:38.6157076+00:00',0,NULL,271,'https://loremflickr.com/320/240?lock=1031871793',1,NULL);
INSERT INTO Media VALUES(41,'2019-11-28 15:38:38.5984467+00:00',0,NULL,141,'https://loremflickr.com/320/240?lock=1946950754',1,NULL);
INSERT INTO Media VALUES(42,'2019-11-28 15:38:38.8060787+00:00',0,NULL,818,'https://loremflickr.com/320/240?lock=809449722',1,NULL);
INSERT INTO Media VALUES(43,'2019-11-28 15:38:38.8405825+00:00',0,NULL,72,'https://loremflickr.com/320/240?lock=708174770',1,NULL);
INSERT INTO Media VALUES(44,'2019-11-28 15:38:38.8230692+00:00',0,NULL,781,'https://loremflickr.com/320/240?lock=1037599220',1,NULL);
INSERT INTO Media VALUES(45,'2019-11-28 15:38:38.9709615+00:00',0,NULL,1018,'https://loremflickr.com/320/240?lock=337893',1,NULL);
INSERT INTO Media VALUES(46,'2019-11-28 15:38:39.0586868+00:00',0,NULL,817,'https://loremflickr.com/320/240?lock=425153880',1,NULL);
INSERT INTO Media VALUES(47,'2019-11-28 15:38:39.0406893+00:00',0,NULL,876,'https://loremflickr.com/320/240?lock=1006306226',1,NULL);
INSERT INTO Media VALUES(48,'2019-11-28 15:38:39.4751445+00:00',0,NULL,336,'https://loremflickr.com/320/240?lock=212324498',1,NULL);
INSERT INTO Media VALUES(49,'2019-11-28 15:38:39.0234675+00:00',0,NULL,622,'https://loremflickr.com/320/240?lock=1368320492',1,NULL);
INSERT INTO Media VALUES(50,'2019-11-28 15:38:39.3731243+00:00',0,NULL,959,'https://loremflickr.com/320/240?lock=559427777',1,NULL);
INSERT INTO Media VALUES(51,'2019-11-28 15:38:39.0058912+00:00',0,NULL,163,'https://loremflickr.com/320/240?lock=1216237717',1,NULL);
INSERT INTO Media VALUES(52,'2019-11-28 15:38:38.9886399+00:00',0,NULL,666,'https://loremflickr.com/320/240?lock=1499233451',1,NULL);
INSERT INTO Media VALUES(53,'2019-11-28 15:38:38.8643089+00:00',0,NULL,59,'https://loremflickr.com/320/240?lock=866318763',1,NULL);
INSERT INTO Media VALUES(54,'2019-11-28 15:38:38.9524196+00:00',0,NULL,332,'https://loremflickr.com/320/240?lock=127153306',1,NULL);
INSERT INTO Media VALUES(55,'2019-11-28 15:38:39.3055716+00:00',0,NULL,192,'https://loremflickr.com/320/240?lock=1478268940',1,NULL);
INSERT INTO Media VALUES(56,'2019-11-28 15:38:38.9178343+00:00',0,NULL,1000,'https://loremflickr.com/320/240?lock=950171008',1,NULL);
INSERT INTO Media VALUES(57,'2019-11-28 15:38:38.8998796+00:00',0,NULL,216,'https://loremflickr.com/320/240?lock=240379281',1,NULL);
INSERT INTO Media VALUES(58,'2019-11-28 15:38:38.8820826+00:00',0,NULL,370,'https://loremflickr.com/320/240?lock=1361242824',1,NULL);
INSERT INTO Media VALUES(59,'2019-11-28 15:38:39.4072143+00:00',0,NULL,389,'https://loremflickr.com/320/240?lock=1877667727',1,NULL);
INSERT INTO Media VALUES(60,'2019-11-28 15:38:38.9349963+00:00',0,NULL,589,'https://loremflickr.com/320/240?lock=849530407',1,NULL);
CREATE TABLE IF NOT EXISTS "ProductAttributeGroup" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_ProductAttributeGroup" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "Name" TEXT NOT NULL
);
CREATE TABLE IF NOT EXISTS "ProductOption" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_ProductOption" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "Name" TEXT NOT NULL
);
CREATE TABLE IF NOT EXISTS "Stock" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Stock" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL
);
CREATE TABLE IF NOT EXISTS "VendorAddress" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_VendorAddress" PRIMARY KEY AUTOINCREMENT,
    "Address_Street" TEXT NULL,
    "Address_FirstAddress" TEXT NULL,
    "Address_SecondAddress" TEXT NULL,
    "Address_City" TEXT NULL,
    "Address_District" TEXT NULL,
    "Address_State" TEXT NULL,
    "Address_PostalCode" TEXT NULL,
    "Address_Number" TEXT NULL,
    "Address_Complement" TEXT NULL,
    "Address_Country" TEXT NULL,
    "WhoReceives" TEXT NULL,
    "PhoneNumber" TEXT NULL
);
INSERT INTO VendorAddress VALUES(1,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(2,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(3,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(4,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(5,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(6,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(7,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(8,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(9,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(10,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(11,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(12,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(13,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(14,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(15,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(16,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(17,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(18,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(19,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(20,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(21,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(22,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(23,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(24,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(25,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(26,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(27,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(28,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(29,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(30,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(31,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(32,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(33,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(34,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(35,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(36,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(37,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(38,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(39,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(40,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(41,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(42,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(43,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(44,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(45,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(46,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(47,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(48,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(49,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(50,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(51,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(52,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(53,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(54,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(55,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(56,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(57,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(58,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(59,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
INSERT INTO VendorAddress VALUES(60,'rua do conhecimento','','','Varginha','distrito 9','sp','40028922','666','busque conhecimento','br',NULL,NULL);
CREATE TABLE IF NOT EXISTS "Wishlist" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Wishlist" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "StormyCustomerId" TEXT NULL
);
INSERT INTO Wishlist VALUES(1,'2019-11-28 15:38:37.4545659+00:00',0,NULL);
INSERT INTO Wishlist VALUES(2,'2019-11-28 15:38:37.600589+00:00',0,NULL);
INSERT INTO Wishlist VALUES(3,'2019-11-28 15:38:37.3838737+00:00',0,NULL);
INSERT INTO Wishlist VALUES(4,'2019-11-28 15:38:37.3132379+00:00',0,NULL);
INSERT INTO Wishlist VALUES(5,'2019-11-28 15:38:37.2445245+00:00',0,NULL);
INSERT INTO Wishlist VALUES(6,'2019-11-28 15:38:37.6943598+00:00',0,NULL);
INSERT INTO Wishlist VALUES(7,'2019-11-28 15:38:37.1767136+00:00',0,NULL);
INSERT INTO Wishlist VALUES(8,'2019-11-28 15:38:37.1081514+00:00',0,NULL);
INSERT INTO Wishlist VALUES(9,'2019-11-28 15:38:37.5247061+00:00',0,NULL);
INSERT INTO Wishlist VALUES(10,'2019-11-28 15:38:36.8345154+00:00',0,NULL);
INSERT INTO Wishlist VALUES(11,'2019-11-28 15:38:40.3263956+00:00',0,NULL);
INSERT INTO Wishlist VALUES(12,'2019-11-28 15:38:40.7693629+00:00',0,NULL);
CREATE TABLE IF NOT EXISTS "AspNetRoleClaims" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_AspNetRoleClaims" PRIMARY KEY AUTOINCREMENT,
    "RoleId" TEXT NOT NULL,
    "ClaimType" TEXT NULL,
    "ClaimValue" TEXT NULL,
    CONSTRAINT "FK_AspNetRoleClaims_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES "AspNetRoles" ("Id") ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS "AspNetUserClaims" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_AspNetUserClaims" PRIMARY KEY AUTOINCREMENT,
    "UserId" TEXT NOT NULL,
    "ClaimType" TEXT NULL,
    "ClaimValue" TEXT NULL,
    CONSTRAINT "FK_AspNetUserClaims_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS "AspNetUserLogins" (
    "LoginProvider" TEXT NOT NULL,
    "ProviderKey" TEXT NOT NULL,
    "ProviderDisplayName" TEXT NULL,
    "UserId" TEXT NOT NULL,
    CONSTRAINT "PK_AspNetUserLogins" PRIMARY KEY ("LoginProvider", "ProviderKey"),
    CONSTRAINT "FK_AspNetUserLogins_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS "AspNetUserRoles" (
    "UserId" TEXT NOT NULL,
    "RoleId" TEXT NOT NULL,
    CONSTRAINT "PK_AspNetUserRoles" PRIMARY KEY ("UserId", "RoleId"),
    CONSTRAINT "FK_AspNetUserRoles_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES "AspNetRoles" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_AspNetUserRoles_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS "AspNetUserTokens" (
    "UserId" TEXT NOT NULL,
    "LoginProvider" TEXT NOT NULL,
    "Name" TEXT NOT NULL,
    "Value" TEXT NULL,
    CONSTRAINT "PK_AspNetUserTokens" PRIMARY KEY ("UserId", "LoginProvider", "Name"),
    CONSTRAINT "FK_AspNetUserTokens_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "AspNetUsers" ("Id") ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS "Entity" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Entity" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "Slug" TEXT NOT NULL,
    "Name" TEXT NOT NULL,
    "EntityId" INTEGER NOT NULL,
    "EntityTypeId" TEXT NOT NULL,
    CONSTRAINT "FK_Entity_EntityType_EntityTypeId" FOREIGN KEY ("EntityTypeId") REFERENCES "EntityType" ("Id") ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS "ProductAttribute" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_ProductAttribute" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "GroupId" INTEGER NOT NULL,
    "Name" TEXT NULL,
    CONSTRAINT "FK_ProductAttribute_ProductAttributeGroup_GroupId" FOREIGN KEY ("GroupId") REFERENCES "ProductAttributeGroup" ("Id") ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS "StormyVendor" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_StormyVendor" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "CompanyName" TEXT NULL,
    "ContactTitle" TEXT NULL,
    "VendorAddressId" INTEGER NOT NULL,
    "ProductId" INTEGER NOT NULL,
    "Phone" TEXT NULL,
    "Email" TEXT NULL,
    "WebSite" TEXT NULL,
    "TypeGoods" TEXT NULL,
    "SizeUrl" TEXT NULL,
    "Logo" TEXT NULL,
    "Note" TEXT NULL,
    CONSTRAINT "FK_StormyVendor_VendorAddress_VendorAddressId" FOREIGN KEY ("VendorAddressId") REFERENCES "VendorAddress" ("Id") ON DELETE CASCADE
);
INSERT INTO StormyVendor VALUES(1,'2019-11-23 17:04:47.7592289-03:00',0,'Albuquerque - Martins','Carl45',1,0,'(82) 1272-8443','Carl25@bol.com.br','marli.net','Health','0','https://loremflickr.com/320/240?lock=1543305879','In aut alias ipsam esse ipsum.');
INSERT INTO StormyVendor VALUES(2,'2019-11-24 01:24:38.2034352-03:00',0,'Macedo - Barros','Tomas_Carvalho38',2,0,'+55 (96) 0588-5663','Tomas_Carvalho@bol.com.br','pedro.net','Music & Movies','0','https://loremflickr.com/320/240?lock=1053147721','dignissimos');
INSERT INTO StormyVendor VALUES(3,'2019-11-07 19:45:00.1318316-03:00',0,'Franco - Carvalho','Monica_Costa52',5,0,'(96) 2979-2974','Monica_Costa47@bol.com.br','warley.net','Automotive','0','https://loremflickr.com/320/240?lock=349109554','ducimus');
INSERT INTO StormyVendor VALUES(4,'2019-11-08 01:17:47.8545191-03:00',0,'Barros, Costa and Franco','Wilbert67',3,0,'(65) 34661-3059','Wilbert.Souza@live.com','larissa.net','Automotive & Computers','0','https://loremflickr.com/320/240?lock=1832340767',replace('Sint perspiciatis dolor nesciunt sapiente nisi tempora minima.\nEst et fugiat incidunt autem voluptatem enim libero esse.\nConsequuntur unde perspiciatis quas dolore non eum nostrum maxime quis.\nEa ut quam non quis quis amet.\nQuas error rerum rerum sint qui omnis qui quidem.','\n',char(10)));
INSERT INTO StormyVendor VALUES(5,'2019-11-10 17:48:14.7160338-03:00',0,'Melo - Moraes','Rafael1',7,0,'(70) 92847-5907','Rafael45@bol.com.br','esther.net','Grocery, Toys & Jewelery','0','https://loremflickr.com/320/240?lock=564312757','veniam');
INSERT INTO StormyVendor VALUES(6,'2019-11-25 01:19:11.6854027-03:00',0,'Martins - Melo','Maureen44',8,0,'+55 (33) 8286-7617','Maureen_Saraiva59@live.com','meire.biz','Garden','0','https://loremflickr.com/320/240?lock=1311086825',replace('Porro sed excepturi aut magnam tempora atque.\nEt aut dolor qui omnis.\nVel similique dolor quibusdam deserunt quisquam.\nNumquam labore fugit rerum quia.','\n',char(10)));
INSERT INTO StormyVendor VALUES(7,'2019-11-26 07:44:05.7313924-03:00',0,'Pereira, Saraiva and Martins','Lynn_Carvalho',9,0,'+55 (70) 3055-1550','Lynn.Carvalho@hotmail.com','dalila.br','Sports, Grocery & Industrial','0','https://loremflickr.com/320/240?lock=1774607853','Itaque rem libero non voluptatibus vitae numquam tenetur quidem accusantium. Distinctio doloremque quia rerum. Pariatur illo praesentium.');
INSERT INTO StormyVendor VALUES(8,'2019-11-15 20:57:40.7321663-03:00',0,'Saraiva, Franco and Batista','Elvira_Martins',10,0,'(17) 46136-4868','Elvira.Martins@gmail.com','eduarda.name','Outdoors & Shoes','0','https://loremflickr.com/320/240?lock=1999470649','Esse corrupti saepe voluptate ullam sit.');
INSERT INTO StormyVendor VALUES(9,'2019-11-11 00:57:33.8190862-03:00',0,'Oliveira, Franco and Souza','Johnnie43',6,0,'+55 (69) 4979-5175','Johnnie.Moraes@yahoo.com','raul.net','Sports, Computers & Health','0','https://loremflickr.com/320/240?lock=2002661750','In est nihil. Sunt quasi aut praesentium itaque molestiae praesentium nam unde minus. Quasi nesciunt et rerum et libero. Atque id dolore minima. Nihil rerum qui veniam quae earum quia.');
INSERT INTO StormyVendor VALUES(10,'2019-11-23 17:33:23.9223361-03:00',0,'Franco, Silva and Pereira','Paul_Martins78',4,0,'(76) 08217-1722','Paul91@bol.com.br','sirineu.info','Grocery, Computers & Toys','0','https://loremflickr.com/320/240?lock=1801086441','A recusandae voluptatem et ut. Quo aut aspernatur nostrum quos nam beatae amet nulla. Et laboriosam iste totam rerum optio fugit consequuntur.');
INSERT INTO StormyVendor VALUES(11,'2019-11-09 12:44:13.5015199-03:00',0,'Xavier, Braga and Melo','Courtney.Barros51',37,0,'+55 (76) 7024-9453','Courtney44@hotmail.com','carla.br','Sports','0','https://loremflickr.com/320/240?lock=250927527','Alias delectus adipisci.');
INSERT INTO StormyVendor VALUES(12,'2019-11-01 13:47:52.4951102-03:00',0,'Saraiva - Xavier','Leigh89',52,0,'+55 (33) 6726-1102','Leigh.Martins11@yahoo.com','joão.net','Computers & Toys','0','https://loremflickr.com/320/240?lock=1037590968',replace('Tempora ducimus sit et iure amet.\nExercitationem eveniet earum consequatur modi omnis qui.\nIpsam est ut est temporibus consequuntur id ea sapiente provident.','\n',char(10)));
INSERT INTO StormyVendor VALUES(13,'2019-11-13 05:31:24.3304504-03:00',0,'Martins LTDA','Andrew.Moraes97',51,0,'+55 (21) 2401-2285','Andrew_Moraes82@gmail.com','ofélia.info','Computers','0','https://loremflickr.com/320/240?lock=862706913','Consequuntur et id accusantium cumque voluptas. Sequi consequuntur possimus quia quibusdam earum et sint enim. Totam quod voluptatem et quisquam expedita eaque.');
INSERT INTO StormyVendor VALUES(14,'2019-11-23 04:17:23.6987008-03:00',0,'Oliveira e Associados','Jesus_Nogueira71',50,0,'(07) 21309-1802','Jesus_Nogueira59@live.com','alessandro.name','Industrial & Automotive','0','https://loremflickr.com/320/240?lock=140110548','Aut rerum doloribus dignissimos neque omnis. Sed voluptas aliquam dignissimos sit. Doloribus ut a perspiciatis voluptatem aliquam consequuntur. Ipsum in hic. Ut voluptatibus eaque et quisquam iure officiis rem aut.');
INSERT INTO StormyVendor VALUES(15,'2019-11-22 02:50:37.5238989-03:00',0,'Santos S.A.','Suzanne_Nogueira23',49,0,'(33) 7178-9640','Suzanne59@gmail.com','carlos.name','Outdoors & Outdoors','0','https://loremflickr.com/320/240?lock=385830756','Beatae reiciendis eligendi velit fugiat doloribus et sapiente est consectetur. Ipsa cum et. Odio iure ad harum numquam. Beatae aut in voluptas consequatur. Enim distinctio nobis voluptas dolor omnis iusto ab dolores.');
INSERT INTO StormyVendor VALUES(16,'2019-11-07 05:16:34.5332703-03:00',0,'Batista, Carvalho and Martins','Kathy.Macedo71',48,0,'(77) 84121-4411','Kathy_Macedo66@live.com','antônio.name','Outdoors','0','https://loremflickr.com/320/240?lock=1076536118','Asperiores necessitatibus sed harum unde.');
INSERT INTO StormyVendor VALUES(17,'2019-11-26 09:45:43.2877805-03:00',0,'Santos, Oliveira and Costa','Sally.Franco96',47,0,'(71) 47439-4643','Sally31@gmail.com','fábio.info','Movies, Grocery & Home','0','https://loremflickr.com/320/240?lock=1956716395','Nesciunt qui dolorum ut eos magnam omnis dolor in. Recusandae ullam rem rerum. Est consectetur molestiae rem maiores qui consequatur dicta. Atque velit itaque quibusdam quidem blanditiis modi sequi id repellat. Laborum fugit assumenda ut dignissimos accusamus voluptates libero quidem.');
INSERT INTO StormyVendor VALUES(18,'2019-11-10 06:39:12.8077932-03:00',0,'Silva S.A.','Aubrey52',46,0,'(34) 35459-3308','Aubrey.Costa@hotmail.com','pablo.org','Movies','0','https://loremflickr.com/320/240?lock=1615374697','ut');
INSERT INTO StormyVendor VALUES(19,'2019-11-13 21:50:45.2508301-03:00',0,'Martins, Martins and Xavier','Anthony_Albuquerque',45,0,'(40) 23141-1194','Anthony_Albuquerque13@live.com','warley.name','Tools','0','https://loremflickr.com/320/240?lock=783680400','Ratione maiores porro vitae illum.');
INSERT INTO StormyVendor VALUES(20,'2019-11-16 10:05:57.7573164-03:00',0,'Oliveira, Macedo and Carvalho','Agnes_Silva90',44,0,'+55 (23) 1641-7180','Agnes.Silva41@gmail.com','eduardo.org','Computers, Music & Books','0','https://loremflickr.com/320/240?lock=1979303143',replace('Voluptatem sed est optio et assumenda incidunt suscipit sequi et.\nSoluta tempore sequi ipsum est quibusdam quo ut aut.\nOfficia nihil aut ut voluptatem.\nEa ex ex totam est maxime nihil voluptatem.\nUt voluptates consequatur enim.\nMolestiae rerum aut enim sed aut architecto voluptatibus corporis.','\n',char(10)));
INSERT INTO StormyVendor VALUES(21,'2019-11-04 00:38:24.0341223-03:00',0,'Costa - Pereira','Irvin.Franco',43,0,'+55 (49) 4020-7879','Irvin_Franco@yahoo.com','núbia.name','Automotive, Automotive & Movies','0','https://loremflickr.com/320/240?lock=22103606','Sed quis quo consequuntur. Autem quis iusto qui in. Dolorem officia amet voluptatem quaerat eos rerum rerum ducimus. Nihil nemo voluptatem. Modi perferendis laborum quia et eum quae vitae voluptatem.');
INSERT INTO StormyVendor VALUES(22,'2019-11-06 12:50:23.0048318-03:00',0,'Saraiva - Oliveira','Shawn_Braga35',42,0,'(06) 78033-0283','Shawn_Braga@live.com','yuri.com','Games, Toys & Electronics','0','https://loremflickr.com/320/240?lock=1785101182','Deserunt mollitia pariatur earum nulla minus eos quod est voluptates.');
INSERT INTO StormyVendor VALUES(23,'2019-11-01 19:58:27.3246217-03:00',0,'Nogueira - Macedo','Penny.Oliveira41',21,0,'(62) 74636-9288','Penny_Oliveira30@yahoo.com','marcelo.net','Electronics & Kids','0','https://loremflickr.com/320/240?lock=1180621566','autem');
INSERT INTO StormyVendor VALUES(24,'2019-11-26 17:57:42.2024295-03:00',0,'Pereira e Associados','Tami.Xavier62',59,0,'+55 (89) 2232-4864','Tami1@gmail.com','yago.com','Jewelery & Tools','0','https://loremflickr.com/320/240?lock=1224175989',replace('Velit sint cum ea voluptatem consectetur.\nAut rem molestiae nostrum.\nPerferendis nulla cupiditate veniam iste iusto voluptas consequatur.\nExcepturi ut cumque.\nNumquam aut itaque sed officiis omnis non quas debitis.\nConsequuntur dicta ad facilis ipsa.','\n',char(10)));
INSERT INTO StormyVendor VALUES(25,'2019-11-16 06:02:54.7194364-03:00',0,'Costa, Martins and Batista','Jana_Nogueira',11,0,'(64) 88682-4728','Jana_Nogueira67@hotmail.com','víctor.info','Kids, Kids & Automotive','0','https://loremflickr.com/320/240?lock=914247244',replace('Soluta sunt voluptatem qui mollitia dolor.\nNeque ut unde.\nQuo quos deleniti molestias.\nDeserunt qui quod molestiae voluptate architecto sapiente sunt cum dolor.\nQuae illo voluptas officia eaque modi quo.\nA ipsum ex sit cumque in.','\n',char(10)));
INSERT INTO StormyVendor VALUES(26,'2019-11-14 20:47:20.6119761-03:00',0,'Carvalho Comércio','Reginald_Pereira63',12,0,'(76) 1739-0473','Reginald.Pereira8@bol.com.br','eduardo.com','Toys, Garden & Baby','0','https://loremflickr.com/320/240?lock=705081220','Aut exercitationem excepturi aliquam voluptates.');
INSERT INTO StormyVendor VALUES(27,'2019-11-11 17:46:30.1815247-03:00',0,'Oliveira e Associados','Rex81',18,0,'(06) 7064-9179','Rex_Souza29@hotmail.com','ladislau.br','Beauty','0','https://loremflickr.com/320/240?lock=118992603','dolor');
INSERT INTO StormyVendor VALUES(28,'2019-11-25 21:40:48.8836076-03:00',0,'Batista, Albuquerque and Santos','Alberto_Braga32',15,0,'+55 (09) 1669-5146','Alberto.Braga93@gmail.com','paula.net','Games & Books','0','https://loremflickr.com/320/240?lock=1426536514','Recusandae optio nobis blanditiis.');
INSERT INTO StormyVendor VALUES(29,'2019-11-15 22:41:17.9575472-03:00',0,'Silva, Pereira and Batista','Chad_Martins31',14,0,'+55 (01) 7133-3408','Chad59@bol.com.br','marcela.name','Industrial, Automotive & Health','0','https://loremflickr.com/320/240?lock=1244116219','Qui provident assumenda adipisci delectus. Inventore voluptate et facere nulla voluptatem autem qui. Facilis ut enim accusantium illum aut.');
INSERT INTO StormyVendor VALUES(30,'2019-11-25 03:51:25.322874-03:00',0,'Pereira, Martins and Macedo','William.Xavier18',19,0,'(04) 3099-7697','William62@gmail.com','alessandra.info','Computers','0','https://loremflickr.com/320/240?lock=376883422','Et atque officiis.');
INSERT INTO StormyVendor VALUES(31,'2019-11-11 12:06:05.9591835-03:00',0,'Carvalho, Barros and Batista','Clifford60',16,0,'(97) 3604-6105','Clifford46@live.com','deneval.org','Movies & Jewelery','0','https://loremflickr.com/320/240?lock=1951613423','Reprehenderit ex corrupti.');
INSERT INTO StormyVendor VALUES(32,'2019-11-27 13:40:42.3806665-03:00',0,'Saraiva S.A.','Edgar31',13,0,'(11) 0012-3490','Edgar61@yahoo.com','guilherme.org','Tools, Movies & Baby','0','https://loremflickr.com/320/240?lock=1104305600',replace('Aut et cumque architecto voluptas aliquam expedita.\nEa veniam mollitia.\nAutem tenetur libero id.\nExplicabo rerum est et ipsam rerum voluptatem.','\n',char(10)));
INSERT INTO StormyVendor VALUES(33,'2019-11-14 04:30:52.466596-03:00',0,'Batista, Xavier and Barros','Nadine50',53,0,'(16) 68367-2566','Nadine44@hotmail.com','carlos.com','Computers & Tools','0','https://loremflickr.com/320/240?lock=1989675619','Nisi repudiandae est aliquid corrupti quis. Delectus debitis libero impedit magnam expedita. Eaque aliquid autem qui reiciendis accusantium natus minus. Ea et exercitationem earum libero tenetur corporis dolorem tenetur.');
INSERT INTO StormyVendor VALUES(34,'2019-11-15 16:46:34.332398-03:00',0,'Moraes, Santos and Xavier','Erik_Franco',54,0,'+55 (35) 3910-2289','Erik.Franco86@bol.com.br','breno.info','Garden & Grocery','0','https://loremflickr.com/320/240?lock=1493816632','Voluptatem architecto quia et doloribus architecto quis temporibus.');
INSERT INTO StormyVendor VALUES(35,'2019-11-01 20:43:37.2972573-03:00',0,'Silva, Carvalho and Souza','Colin_Costa50',20,0,'(19) 5490-8889','Colin.Costa50@gmail.com','janaína.net','Garden','0','https://loremflickr.com/320/240?lock=943939735','quaerat');
INSERT INTO StormyVendor VALUES(36,'2019-11-25 18:32:42.7221145-03:00',0,'Pereira - Saraiva','Wilbur.Batista',55,0,'+55 (46) 5441-0382','Wilbur_Batista@gmail.com','pablo.biz','Music','0','https://loremflickr.com/320/240?lock=1160648008','ducimus');
INSERT INTO StormyVendor VALUES(37,'2019-11-08 15:43:47.7342251-03:00',0,'Barros - Costa','Elias22',36,0,'(66) 4412-1131','Elias.Braga@bol.com.br','lorraine.biz','Garden','0','https://loremflickr.com/320/240?lock=859772175','ut');
INSERT INTO StormyVendor VALUES(38,'2019-11-13 17:03:32.7626672-03:00',0,'Barros, Santos and Carvalho','Sherri93',35,0,'+55 (72) 0331-3984','Sherri_Santos13@hotmail.com','júlia.biz','Beauty, Automotive & Health','0','https://loremflickr.com/320/240?lock=1395262857',replace('Vitae quisquam ipsam rerum aliquid fugit officiis voluptas.\nNon officiis vitae exercitationem omnis deserunt similique.\nUt ea possimus omnis et at et et.\nIure nisi illum inventore quis doloribus quae sed exercitationem sit.\nQuia eaque debitis sunt eius ab voluptas veniam.','\n',char(10)));
INSERT INTO StormyVendor VALUES(39,'2019-11-26 08:47:14.8999752-03:00',0,'Silva LTDA','Nellie.Carvalho',34,0,'+55 (83) 2746-0897','Nellie_Carvalho58@bol.com.br','janaína.name','Sports, Industrial & Health','0','https://loremflickr.com/320/240?lock=883484789','Nam mollitia et quae magni. Necessitatibus inventore totam eveniet eius deleniti qui odio. Sed iste dolor et ut velit accusamus vitae aliquid. Exercitationem possimus voluptate voluptatem. Vel recusandae sit doloremque in. Non quia tempora consequuntur et omnis dolor nemo quas.');
INSERT INTO StormyVendor VALUES(40,'2019-11-05 19:07:56.3089272-03:00',0,'Santos, Xavier and Saraiva','Lynette.Batista',33,0,'(05) 95094-1525','Lynette96@bol.com.br','bruna.biz','Music, Toys & Sports','0','https://loremflickr.com/320/240?lock=1681400842','Fugit voluptatibus vel esse omnis.');
INSERT INTO StormyVendor VALUES(41,'2019-11-01 23:04:01.3394001-03:00',0,'Albuquerque Comércio','Willis.Albuquerque',32,0,'+55 (98) 9255-6792','Willis.Albuquerque4@bol.com.br','lucas.biz','Clothing & Automotive','0','https://loremflickr.com/320/240?lock=344334223',replace('Et culpa eos voluptas.\nConsequatur sit omnis velit rerum.\nCupiditate quia qui.\nAd et aut eius qui nostrum sunt modi minima.\nNobis aspernatur ut ullam consequatur blanditiis.\nUnde quos qui et et velit quos nam.','\n',char(10)));
INSERT INTO StormyVendor VALUES(42,'2019-11-14 21:32:38.9136844-03:00',0,'Moraes LTDA','Melvin.Santos89',31,0,'+55 (98) 6260-6014','Melvin60@yahoo.com','marcelo.biz','Toys','0','https://loremflickr.com/320/240?lock=1063661971','Commodi maiores cum dolor reprehenderit cum. Qui iusto ducimus natus officia itaque. Veritatis totam est ex voluptas voluptate.');
INSERT INTO StormyVendor VALUES(43,'2019-11-13 09:19:14.1216388-03:00',0,'Carvalho, Moreira and Franco','Phillip47',38,0,'(67) 60816-8966','Phillip_Saraiva@live.com','fabrício.info','Clothing & Home','0','https://loremflickr.com/320/240?lock=1147674135',replace('Voluptatum eos et facere sit et dignissimos.\nVoluptates quisquam et consequatur qui dignissimos voluptas excepturi.','\n',char(10)));
INSERT INTO StormyVendor VALUES(44,'2019-11-16 17:34:37.9899642-03:00',0,'Moraes - Saraiva','Vincent_Macedo99',30,0,'+55 (75) 1655-8830','Vincent_Macedo72@gmail.com','vicente.com','Beauty, Home & Health','0','https://loremflickr.com/320/240?lock=169949252','sed');
INSERT INTO StormyVendor VALUES(45,'2019-11-21 12:15:11.1265464-03:00',0,'Oliveira LTDA','Veronica_Santos93',28,0,'+55 (48) 8688-5228','Veronica_Santos96@hotmail.com','janaína.com','Kids, Industrial & Computers','0','https://loremflickr.com/320/240?lock=268904262','ea');
INSERT INTO StormyVendor VALUES(46,'2019-11-22 02:58:16.5109386-03:00',0,'Franco - Pereira','Mathew_Saraiva35',27,0,'(79) 45065-6694','Mathew.Saraiva56@live.com','vitória.org','Beauty, Games & Baby','0','https://loremflickr.com/320/240?lock=1968774806','Sed itaque repudiandae qui ab rerum. Aut corrupti recusandae voluptatem minus fugit aliquam vel fugit. Atque dignissimos eum autem hic nostrum dolore libero. Sed sint sit sapiente omnis est aut. Pariatur voluptatem sapiente ut consectetur iusto dolorem. Ut maxime occaecati a enim et.');
INSERT INTO StormyVendor VALUES(47,'2019-11-22 20:47:41.8528393-03:00',0,'Batista, Reis and Barros','Kathryn.Martins43',17,0,'(12) 3022-3987','Kathryn.Martins44@yahoo.com','margarida.name','Home','0','https://loremflickr.com/320/240?lock=2016143318','Quia commodi perspiciatis ducimus asperiores fugiat.');
INSERT INTO StormyVendor VALUES(48,'2019-11-26 20:29:44.0102809-03:00',0,'Reis - Moraes','Katrina.Barros95',26,0,'(96) 7950-7626','Katrina.Barros@live.com','salvador.name','Computers & Kids','0','https://loremflickr.com/320/240?lock=64460769','Non dicta molestiae quod totam dolores quia veniam maiores totam.');
INSERT INTO StormyVendor VALUES(49,'2019-11-02 03:48:51.153514-03:00',0,'Reis, Oliveira and Franco','Brenda18',24,0,'(61) 74641-1487','Brenda24@hotmail.com','danilo.net','Movies & Clothing','0','https://loremflickr.com/320/240?lock=1109247947','Quo deserunt amet excepturi. Quaerat repudiandae qui dolorum cum delectus. Adipisci delectus quia. Dolorum ullam accusamus aut. Aut ut ut fugit voluptatem.');
INSERT INTO StormyVendor VALUES(50,'2019-11-21 12:51:32.2502671-03:00',0,'Moraes, Carvalho and Barros','Kathy_Albuquerque',23,0,'(38) 73568-3379','Kathy92@bol.com.br','danilo.org','Shoes','0','https://loremflickr.com/320/240?lock=717935046',replace('Labore ad in qui similique eius modi et facere.\nDistinctio esse iure at laborum explicabo veniam accusamus blanditiis.\nRem consectetur et.\nSaepe sunt voluptatem velit nemo.\nEt quis rerum praesentium labore eos dolores exercitationem quis.','\n',char(10)));
INSERT INTO StormyVendor VALUES(51,'2019-11-14 12:23:30.2011213-03:00',0,'Carvalho Comércio','Ann72',22,0,'(36) 9414-7892','Ann_Carvalho67@gmail.com','karla.biz','Movies','0','https://loremflickr.com/320/240?lock=813632720','Omnis consequuntur repellat eveniet.');
INSERT INTO StormyVendor VALUES(52,'2019-11-02 17:17:20.9230861-03:00',0,'Batista, Oliveira and Braga','Gina_Carvalho',29,0,'(26) 32975-6157','Gina73@hotmail.com','carla.net','Toys','0','https://loremflickr.com/320/240?lock=971183100',replace('Sapiente sed quis animi omnis non dolor dolorem.\nEa perspiciatis et fugit.\nMagnam fuga enim similique eveniet.','\n',char(10)));
INSERT INTO StormyVendor VALUES(53,'2019-11-09 19:31:25.2636889-03:00',0,'Souza, Franco and Carvalho','Ernestine_Nogueira57',39,0,'(66) 94105-4954','Ernestine.Nogueira@hotmail.com','carlos.br','Toys & Shoes','0','https://loremflickr.com/320/240?lock=2007926036','Hic esse voluptatem corporis laborum ut.');
INSERT INTO StormyVendor VALUES(54,'2019-11-18 04:53:13.1972122-03:00',0,'Albuquerque - Melo','Karla8',40,0,'(03) 9375-5055','Karla.Batista@bol.com.br','paulo.info','Industrial, Toys & Toys','0','https://loremflickr.com/320/240?lock=889353462','Velit ducimus eveniet quibusdam velit aliquid non et.');
INSERT INTO StormyVendor VALUES(55,'2019-11-07 02:29:55.0643453-03:00',0,'Souza, Macedo and Melo','Geoffrey_Batista28',41,0,'+55 (45) 8197-4823','Geoffrey_Batista@gmail.com','meire.biz','Electronics, Baby & Music','0','https://loremflickr.com/320/240?lock=1619550608','Hic quia error eius fugiat voluptas ipsa iure consequuntur. Rerum voluptates eveniet officia adipisci et quae consectetur id. Ea reprehenderit et. Sit et earum et est iure et iusto.');
INSERT INTO StormyVendor VALUES(56,'2019-11-25 18:36:39.9413507-03:00',0,'Carvalho, Martins and Saraiva','Tanya29',58,0,'(60) 51168-0549','Tanya52@gmail.com','meire.com','Computers, Outdoors & Grocery','0','https://loremflickr.com/320/240?lock=1232251080',replace('Cupiditate dolor veniam enim tenetur cupiditate iusto rerum.\nEum nihil sequi minus voluptatem.','\n',char(10)));
INSERT INTO StormyVendor VALUES(57,'2019-11-05 06:15:01.1871381-03:00',0,'Moreira, Nogueira and Moreira','Bridget_Moraes93',57,0,'(69) 93547-8648','Bridget_Moraes@hotmail.com','roberto.net','Kids & Shoes','0','https://loremflickr.com/320/240?lock=347857815',replace('Et non quis dolores.\nItaque enim consequatur voluptatibus est quo.\nQui rerum nihil modi id pariatur dolores et.\nProvident vero aperiam inventore aspernatur molestiae.\nQuae sunt architecto sed quisquam.','\n',char(10)));
INSERT INTO StormyVendor VALUES(58,'2019-11-19 13:38:36.6498109-03:00',0,'Albuquerque - Melo','Ivan_Silva',56,0,'+55 (19) 8826-3149','Ivan4@hotmail.com','isabela.info','Sports & Industrial','0','https://loremflickr.com/320/240?lock=488427832','Qui commodi beatae nobis est ipsum rerum.');
INSERT INTO StormyVendor VALUES(59,'2019-11-09 20:47:01.5314155-03:00',0,'Carvalho - Oliveira','Ruben.Batista67',25,0,'(69) 72367-5051','Ruben.Batista@hotmail.com','antônio.com','Toys & Tools','0','https://loremflickr.com/320/240?lock=1671473741','Consectetur quos omnis.');
INSERT INTO StormyVendor VALUES(60,'2019-11-22 02:06:30.0765395-03:00',0,'Martins, Silva and Franco','Mark_Martins',60,0,'(19) 47496-5771','Mark_Martins89@yahoo.com','sílvia.info','Sports, Automotive & Shoes','0','https://loremflickr.com/320/240?lock=1416175513','Delectus aut est quia dolor asperiores impedit rerum molestiae. Modi culpa saepe accusamus quia sed veniam quia. Laboriosam accusamus quia sed. Consequatur fuga aut qui explicabo officia qui praesentium deleniti qui. Est dolore deserunt velit omnis nobis accusantium dolorum. Laborum dolorem non similique.');
CREATE TABLE IF NOT EXISTS "StormyProduct" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_StormyProduct" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "SKU" TEXT NOT NULL,
    "ProductName" TEXT NOT NULL,
    "Slug" TEXT NULL,
    "BrandId" INTEGER NOT NULL,
    "VendorId" INTEGER NOT NULL,
    "CategoryId" INTEGER NOT NULL,
    "MediaId" INTEGER NULL,
    "ProductLinksId" INTEGER NULL,
    "ShortDescription" TEXT NULL,
    "Description" TEXT NULL,
    "QuantityPerUnity" INTEGER NOT NULL,
    "AvailableSizes" TEXT NULL,
    "UnitPrice" TEXT NOT NULL,
    "Discount" TEXT NOT NULL,
    "UnitWeight" REAL NOT NULL,
    "Height" REAL NOT NULL,
    "Width" REAL NOT NULL,
    "Length" REAL NOT NULL,
    "Diameter" REAL NULL,
    "UnitsInStock" INTEGER NOT NULL,
    "UnitsOnOrder" INTEGER NOT NULL,
    "ThumbnailImage" TEXT NULL,
    "Note" TEXT NULL,
    "ProductCost" TEXT NOT NULL,
    "PublishedOn" TEXT NULL,
    "CreatedOn" TEXT NULL,
    "RatingAverage" INTEGER NOT NULL,
    "StockId" INTEGER NULL,
    CONSTRAINT "FK_StormyProduct_Brand_BrandId" FOREIGN KEY ("BrandId") REFERENCES "Brand" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_StormyProduct_Stock_StockId" FOREIGN KEY ("StockId") REFERENCES "Stock" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_StormyProduct_StormyVendor_VendorId" FOREIGN KEY ("VendorId") REFERENCES "StormyVendor" ("Id") ON DELETE RESTRICT
);
INSERT INTO StormyProduct VALUES(1,'2019-11-28 15:38:36.9985183+00:00',0,'f92x13z1q9aqf8rl','Unbranded Frozen Pizza','porro-autem-rem',3,8,0,NULL,NULL,NULL,NULL,60,'GG,G,M,P,PP','40.7849620286305','0.0',0.75548273779241492675,19.548738362057477502,7.9190189172136680184,6.9943045517403188426,NULL,10,0,'http://lorempixel.com/640/480/fashion','Natus totam maiores accusamus quae molestiae temporibus porro harum.','0.828866605101557',NULL,'2019-06-03 02:18:58.1166741',0,NULL);
INSERT INTO StormyProduct VALUES(2,'2019-11-28 15:38:37.1234887+00:00',0,'rjiorq5e2yr3bbuz','Gorgeous Cotton Gloves','optio-voluptatibus-eaque',8,7,0,NULL,NULL,NULL,NULL,72,'GG,G,M,P,PP','22.7757035395017','0.0',0.39661986538982946237,7.8577659366921368544,18.400681777112502857,1.7272812033664812769,NULL,9,2,'http://lorempixel.com/640/480/fashion','Ab quia distinctio dolores qui.','0.640358542390335',NULL,'2019-03-10 17:16:12.1382556',0,NULL);
INSERT INTO StormyProduct VALUES(3,'2019-11-28 15:38:37.191922+00:00',0,'4uwn47yiin2odkvi','Handcrafted Cotton Shoes','ab-et-veniam',6,6,0,NULL,NULL,NULL,NULL,0,'GG,G,M,P,PP','97.6321462996454','0.0',0.23987259075039651934,6.994408457537371504,16.701121303579363086,15.880959040895550771,NULL,6,2,'http://lorempixel.com/640/480/fashion','Eligendi totam sed.','0.84547024445863',NULL,'2018-11-28 19:58:45.0447471',0,NULL);
INSERT INTO StormyProduct VALUES(4,'2019-11-28 15:38:37.2595177+00:00',0,'gwjlwo4srg8t13qr','Handcrafted Cotton Chicken','corporis-maiores-aut',9,5,0,NULL,NULL,NULL,NULL,0,'GG,G,M,P,PP','34.689890236915','0.0',0.63557376649024610593,9.6096781127199903949,19.34151152118179695,14.390654836031913533,NULL,3,2,'http://lorempixel.com/640/480/fashion','Rem similique quia dolorem delectus.','0.56973372333205',NULL,'2019-06-05 17:23:30.0784309',0,NULL);
INSERT INTO StormyProduct VALUES(5,'2019-11-28 15:38:37.3288243+00:00',0,'7vfg6g7ihfhmn00y','Generic Frozen Pizza','dolores-non-molestias',7,4,0,NULL,NULL,NULL,NULL,94,'GG,G,M,P,PP','53.5330377302752','0.0',0.92011162728076412165,12.452921696218160363,4.4728202565912251742,1.5866218272534300393,NULL,9,1,'http://lorempixel.com/640/480/fashion','Dolores et ut quas.','0.658842997000945',NULL,'2019-07-26 16:25:26.9770496',0,NULL);
INSERT INTO StormyProduct VALUES(6,'2019-11-28 15:38:37.3994583+00:00',0,'qbpdgfrum7w0ikel','Tasty Granite Hat','qui-nemo-officiis',2,9,0,NULL,NULL,NULL,NULL,12,'GG,G,M,P,PP','50.8679569470081','0.0',0.33774814351356968744,4.7603225273826730301,16.348980310535516479,11.656031076170517479,NULL,4,0,'http://lorempixel.com/640/480/fashion','Ex eveniet deserunt numquam sapiente ut distinctio mollitia aut suscipit.','0.723427677863942',NULL,'2019-02-13 02:24:41.4738064',0,NULL);
INSERT INTO StormyProduct VALUES(7,'2019-11-28 15:38:37.4702349+00:00',0,'kj0xbejzdub7po77','Intelligent Rubber Keyboard','aspernatur-enim-nihil',10,3,0,NULL,NULL,NULL,NULL,64,'GG,G,M,P,PP','9.76551399089653','0.0',0.40609420854882066764,8.2432862777464492864,4.1727951961442801831,7.5028544615501786552,NULL,3,2,'http://lorempixel.com/640/480/fashion','In blanditiis repellendus culpa tempora provident vero possimus unde.','0.212522260943671',NULL,'2019-11-07 03:35:20.6383048',0,NULL);
INSERT INTO StormyProduct VALUES(8,'2019-11-28 15:38:37.5403702+00:00',0,'0og727tdbpd7b36v','Sleek Steel Cheese','quia-sequi-saepe',1,2,0,NULL,NULL,NULL,NULL,68,'GG,G,M,P,PP','40.0091403350277','0.0',0.25952127867356000745,1.1856778367355829129,6.2365473728797145014,12.873059876204031581,NULL,5,0,'http://lorempixel.com/640/480/fashion','Voluptatem placeat non quo commodi praesentium aut tempora in adipisci.','0.37117729493006',NULL,'2019-03-29 22:06:47.3455969',0,NULL);
INSERT INTO StormyProduct VALUES(9,'2019-11-28 15:38:37.6179377+00:00',0,'dlfp4y80bsmimysr','Handmade Granite Gloves','velit-excepturi-explicabo',4,1,0,NULL,NULL,NULL,NULL,76,'GG,G,M,P,PP','2.56894654713988','0.0',0.36132291954072326412,2.3815405109811296213,15.558574840220890322,5.2536297027271379178,NULL,7,0,'http://lorempixel.com/640/480/fashion','Omnis id voluptas corporis perspiciatis.','0.256665647615057',NULL,'2019-10-06 10:28:53.6306808',0,NULL);
INSERT INTO StormyProduct VALUES(10,'2019-11-28 15:38:37.7074165+00:00',0,'j38porl0y4mrs3rw','Rustic Wooden Chips','qui-minus-id',5,10,0,NULL,NULL,NULL,NULL,14,'GG,G,M,P,PP','82.1868761825314','0.0',0.8285639369061980064,8.9465989866045312339,10.483837751431314799,11.413304656936464453,NULL,8,1,'http://lorempixel.com/640/480/fashion','Placeat molestiae iste suscipit repellendus in.','0.032715203255748',NULL,'2019-11-18 17:26:09.4245921',0,NULL);
INSERT INTO StormyProduct VALUES(11,'2019-11-28 15:38:38.5854196+00:00',0,'6yd7vpeo7t8gnsf8','Generic Rubber Mouse','et-et-est',11,11,0,NULL,NULL,NULL,NULL,60,'GG,G,M,P,PP','32.1093130540612','0.0',0.73647711646579072652,15.447547081135002855,18.937346238613756099,7.0687975497305384209,NULL,4,0,'http://lorempixel.com/640/480/fashion','Magnam perspiciatis id labore.','0.830765037252924',NULL,'2019-10-18 00:09:15.2126354',0,NULL);
INSERT INTO StormyProduct VALUES(12,'2019-11-28 15:38:39.0664858+00:00',0,'j15waa77qd5knuhu','Sleek Plastic Table','cupiditate-aut-quisquam',29,12,0,NULL,NULL,NULL,NULL,72,'GG,G,M,P,PP','31.7390776387132','0.0',0.658381096393978682,1.0284261894544708404,3.6177694106557263253,11.149190046893988181,NULL,6,1,'http://lorempixel.com/640/480/fashion','Enim pariatur repellendus voluptatibus et omnis ut ut.','0.088178001385265',NULL,'2019-11-04 23:41:32.7662256',0,NULL);
INSERT INTO StormyProduct VALUES(13,'2019-11-28 15:38:39.0840682+00:00',0,'dj1v6o5o63mslmoo','Gorgeous Rubber Car','quos-incidunt-eaque',20,13,0,NULL,NULL,NULL,NULL,24,'GG,G,M,P,PP','44.6696456264097','0.0',0.87547362124336591815,5.1088098744437147047,19.384653130259668074,19.575417299091544265,NULL,3,0,'http://lorempixel.com/640/480/fashion','Consequuntur et id necessitatibus esse labore voluptas et.','0.371959450362231',NULL,'2019-07-14 15:35:03.9713263',0,NULL);
INSERT INTO StormyProduct VALUES(14,'2019-11-28 15:38:39.1016958+00:00',0,'tpz71894amon6myp','Small Rubber Hat','qui-eius-nulla',31,14,0,NULL,NULL,NULL,NULL,62,'GG,G,M,P,PP','10.6235011530218','0.0',0.77865689004708871223,5.016254317022978526,7.5018714440529565834,6.2967043967436548967,NULL,7,2,'http://lorempixel.com/640/480/fashion','Ex qui deleniti odio omnis officia excepturi.','0.156405416855777',NULL,'2019-03-06 10:10:26.9624266',0,NULL);
INSERT INTO StormyProduct VALUES(15,'2019-11-28 15:38:39.1194224+00:00',0,'2zoxllnn4tnb0o2p','Intelligent Fresh Computer','impedit-harum-quia',36,15,0,NULL,NULL,NULL,NULL,80,'GG,G,M,P,PP','92.2501156070503','0.0',0.070671007070071539812,1.0841646334548316055,6.750088875065599403,17.38017399952754971,NULL,2,1,'http://lorempixel.com/640/480/fashion','Aliquam quae aperiam maxime harum non libero ut.','0.653448161042038',NULL,'2019-04-14 05:37:23.8806006',0,NULL);
INSERT INTO StormyProduct VALUES(16,'2019-11-28 15:38:39.1374352+00:00',0,'uu81yx3k80waaz6b','Gorgeous Granite Bike','illum-nihil-nam',40,16,0,NULL,NULL,NULL,NULL,82,'GG,G,M,P,PP','4.92202132238169','0.0',0.49299243674287218652,17.119647864308042528,15.200677559804486094,2.7187578392768081414,NULL,2,2,'http://lorempixel.com/640/480/fashion','Non possimus deleniti dolorem explicabo esse repellat voluptas reiciendis.','0.114379167144363',NULL,'2019-01-28 14:30:03.0536574',0,NULL);
INSERT INTO StormyProduct VALUES(17,'2019-11-28 15:38:39.156355+00:00',0,'1dz0k6kw7cx7rk13','Handcrafted Soft Shirt','rem-unde-dolorem',27,17,0,NULL,NULL,NULL,NULL,42,'GG,G,M,P,PP','99.1960956245643','0.0',0.84390310423630432445,1.9225548784819221914,6.8530228910283295107,14.844560232406742272,NULL,5,0,'http://lorempixel.com/640/480/fashion','Quidem eligendi maxime ut quia voluptate.','0.0620451672291594',NULL,'2019-10-03 06:55:01.6818869',0,NULL);
INSERT INTO StormyProduct VALUES(18,'2019-11-28 15:38:39.1934422+00:00',0,'ky9puw84lrwok6dh','Ergonomic Soft Salad','fugit-voluptates-numquam',22,18,0,NULL,NULL,NULL,NULL,30,'GG,G,M,P,PP','6.46940963644041','0.0',0.67145144598160466653,4.3774454139068001978,10.195302253214316934,17.281231774613836193,NULL,5,1,'http://lorempixel.com/640/480/fashion','Ut inventore et earum asperiores.','0.765102071112535',NULL,'2019-02-18 07:44:46.3458757',0,NULL);
INSERT INTO StormyProduct VALUES(19,'2019-11-28 15:38:39.2103847+00:00',0,'um6s9a6zatk4vpa0','Licensed Rubber Chicken','quia-et-corrupti',18,19,0,NULL,NULL,NULL,NULL,78,'GG,G,M,P,PP','0.873107184131214','0.0',0.42785918732539712783,9.6783614459812454811,2.3412048008019126221,12.659437608746550551,NULL,4,0,'http://lorempixel.com/640/480/fashion','Sapiente beatae quis aut cumque provident voluptatem.','0.392491595536699',NULL,'2019-01-19 18:28:55.6842759',0,NULL);
INSERT INTO StormyProduct VALUES(20,'2019-11-28 15:38:39.2273366+00:00',0,'kairn3hr1d3k4s82','Tasty Granite Ball','molestiae-adipisci-consequatur',13,20,0,NULL,NULL,NULL,NULL,60,'GG,G,M,P,PP','48.479666443765','0.0',0.56900514083402475851,12.711384375910919075,1.1784007592026148891,8.1546000345398681474,NULL,2,0,'http://lorempixel.com/640/480/fashion','Corrupti minima sit libero enim illo velit repellendus aut perspiciatis.','0.509420546474597',NULL,'2019-08-23 23:37:06.2516393',0,NULL);
INSERT INTO StormyProduct VALUES(21,'2019-11-28 15:38:39.2444994+00:00',0,'9nsl1grh7wgu716r','Small Metal Ball','earum-reiciendis-pariatur',46,21,0,NULL,NULL,NULL,NULL,76,'GG,G,M,P,PP','86.6059661780512','0.0',0.31203323850037217868,13.866663652410109008,7.8255358873054090551,5.3746146081828580776,NULL,2,2,'http://lorempixel.com/640/480/fashion','Nam accusantium minus debitis praesentium quos.','0.0920231542978544',NULL,'2019-05-24 05:29:40.1528238',0,NULL);
INSERT INTO StormyProduct VALUES(22,'2019-11-28 15:38:39.2613409+00:00',0,'qbpp9etqgcul9na2','Licensed Steel Fish','est-sequi-placeat',51,22,0,NULL,NULL,NULL,NULL,26,'GG,G,M,P,PP','20.3946003785332','0.0',0.87565340980685013594,15.778090027988929122,5.9384881262381048472,8.0957442042863654307,NULL,3,1,'http://lorempixel.com/640/480/fashion','Perspiciatis quia itaque nulla quia non.','0.693192181034569',NULL,'2019-08-24 15:06:12.7101133',0,NULL);
INSERT INTO StormyProduct VALUES(23,'2019-11-28 15:38:39.2779815+00:00',0,'t4iu6r357r14bo3k','Sleek Cotton Tuna','ab-nihil-consequatur',58,23,0,NULL,NULL,NULL,NULL,52,'GG,G,M,P,PP','74.5459711526269','0.0',0.65545204452027194808,11.31121951169856743,7.4886974117200342249,2.233567295704766753,NULL,10,1,'http://lorempixel.com/640/480/fashion','Rem rerum numquam natus deserunt.','0.33728717469484',NULL,'2019-07-09 14:41:39.0583018',0,NULL);
INSERT INTO StormyProduct VALUES(24,'2019-11-28 15:38:39.2952392+00:00',0,'p105chwogna89jkn','Practical Granite Mouse','repudiandae-id-consectetur',60,24,0,NULL,NULL,NULL,NULL,74,'GG,G,M,P,PP','99.4016921610579','0.0',0.96376644026663449427,3.5403164334317276384,4.721577405799914473,17.787985867721953781,NULL,6,2,'http://lorempixel.com/640/480/fashion','Blanditiis minima expedita ducimus.','0.700804825732859',NULL,'2019-02-19 03:34:28.4445474',0,NULL);
INSERT INTO StormyProduct VALUES(25,'2019-11-28 15:38:39.3120937+00:00',0,'c1f741k6z03g7iki','Practical Cotton Bike','est-earum-odio',53,25,0,NULL,NULL,NULL,NULL,8,'GG,G,M,P,PP','58.1608630987633','0.0',0.082523140629065752649,11.492506788807226314,1.9588412176625995542,15.369268466890449786,NULL,7,2,'http://lorempixel.com/640/480/fashion','Tempora illo aut consectetur consequatur corrupti nihil dignissimos.','0.299133913730799',NULL,'2019-10-08 15:40:07.6766037',0,NULL);
INSERT INTO StormyProduct VALUES(26,'2019-11-28 15:38:39.3286881+00:00',0,'upfi7s5psl0a4qut','Gorgeous Soft Chair','ut-ut-in',15,26,0,NULL,NULL,NULL,NULL,52,'GG,G,M,P,PP','46.5430249676774','0.0',0.5668277235547209969,7.0777019686427440348,8.8788853817986712613,11.730083704334720806,NULL,7,2,'http://lorempixel.com/640/480/fashion','Assumenda iure aut est optio eligendi.','0.477848464379948',NULL,'2019-01-18 17:59:16.2458271',0,NULL);
INSERT INTO StormyProduct VALUES(27,'2019-11-28 15:38:39.3457829+00:00',0,'9hycf09z0jfvnr9v','Sleek Cotton Pants','explicabo-enim-quibusdam',37,27,0,NULL,NULL,NULL,NULL,0,'GG,G,M,P,PP','81.9264474706382','0.0',0.13300375553453516741,16.096103602599399096,14.168817781921857701,9.312542091734959726,NULL,6,0,'http://lorempixel.com/640/480/fashion','Illum accusamus repudiandae qui qui cupiditate provident officia nisi molestiae.','0.503748458579066',NULL,'2019-04-12 06:43:52.0011971',0,NULL);
INSERT INTO StormyProduct VALUES(28,'2019-11-28 15:38:39.3628446+00:00',0,'33nfa5anf35x6hox','Unbranded Fresh Chicken','corrupti-quisquam-perspiciatis',30,28,0,NULL,NULL,NULL,NULL,28,'GG,G,M,P,PP','38.211271557124','0.0',0.84290759025276995597,13.294724092956037963,5.0239384621493226035,17.069193698963704974,NULL,2,2,'http://lorempixel.com/640/480/fashion','Ut qui harum omnis laudantium impedit eum illo id.','0.569676314280218',NULL,'2019-01-30 21:33:03.7966537',0,NULL);
INSERT INTO StormyProduct VALUES(29,'2019-11-28 15:38:39.3796937+00:00',0,'rl2sodh6o6h2z5lx','Gorgeous Steel Tuna','quae-est-sit',39,29,0,NULL,NULL,NULL,NULL,34,'GG,G,M,P,PP','58.3002148933244','0.0',0.57996940034440225275,9.1673833928850392283,13.474182330758395665,16.326324794593418232,NULL,6,0,'http://lorempixel.com/640/480/fashion','Eum temporibus ea aut eos ad magni et.','0.544196685098203',NULL,'2019-07-29 19:14:16.3752617',0,NULL);
INSERT INTO StormyProduct VALUES(30,'2019-11-28 15:38:39.3968015+00:00',0,'5qzgzyhprivmivxk','Gorgeous Soft Chair','quia-laborum-maiores',25,30,0,NULL,NULL,NULL,NULL,60,'GG,G,M,P,PP','11.6672459112793','0.0',0.11049493081425081075,13.090482632671706752,13.183853811670026345,2.9998460505156994138,NULL,6,0,'http://lorempixel.com/640/480/fashion','Tenetur rerum ducimus.','0.585341830544799',NULL,'2019-07-04 10:45:05.1993847',0,NULL);
INSERT INTO StormyProduct VALUES(31,'2019-11-28 15:38:39.4138167+00:00',0,'vdyqyoerpcio637b','Practical Plastic Pizza','eum-in-nisi',19,31,0,NULL,NULL,NULL,NULL,54,'GG,G,M,P,PP','84.6972322020201','0.0',0.60403173351848116201,1.2093446469909254759,12.97813036664302011,16.720473979469609559,NULL,9,0,'http://lorempixel.com/640/480/fashion','Perspiciatis nesciunt qui qui quibusdam error et voluptas inventore qui.','0.541762545491458',NULL,'2019-08-20 15:36:15.242997',0,NULL);
INSERT INTO StormyProduct VALUES(32,'2019-11-28 15:38:39.4308583+00:00',0,'v351ip6lc6vuqtpt','Unbranded Steel Salad','et-doloribus-nihil',35,32,0,NULL,NULL,NULL,NULL,46,'GG,G,M,P,PP','79.9246130883343','0.0',0.98253523650697205393,16.215236447386089935,8.983404952093682283,14.978456344445447712,NULL,10,2,'http://lorempixel.com/640/480/fashion','Et sed voluptatem debitis et a molestiae reiciendis ut facilis.','0.601554019191095',NULL,'2019-05-26 18:22:36.238977',0,NULL);
INSERT INTO StormyProduct VALUES(33,'2019-11-28 15:38:39.0481928+00:00',0,'t3unzdg6edh16cxl','Incredible Soft Pizza','omnis-eum-odio',32,33,0,NULL,NULL,NULL,NULL,10,'GG,G,M,P,PP','30.4032493524268','0.0',0.79080857885573463406,11.338865505223566287,12.442660131697850899,18.704079095602072158,NULL,2,1,'http://lorempixel.com/640/480/fashion','Aut et delectus accusantium eum nesciunt suscipit et ipsa.','0.729123483285831',NULL,'2019-10-25 17:14:05.0454138',0,NULL);
INSERT INTO StormyProduct VALUES(34,'2019-11-28 15:38:39.0303959+00:00',0,'i07eoh2cpxbbzkdf','Gorgeous Wooden Tuna','est-aut-accusantium',33,34,0,NULL,NULL,NULL,NULL,84,'GG,G,M,P,PP','70.8860382302134','0.0',0.31435851907094869428,11.20701077403827206,18.476636905910744701,13.579516699807493651,NULL,6,1,'http://lorempixel.com/640/480/fashion','Ratione voluptas labore excepturi.','0.557989128659474',NULL,'2019-05-18 15:29:19.0520505',0,NULL);
INSERT INTO StormyProduct VALUES(35,'2019-11-28 15:38:39.0130848+00:00',0,'k3j3spavjag0amob','Practical Rubber Chicken','voluptate-tenetur-fugiat',34,35,0,NULL,NULL,NULL,NULL,82,'GG,G,M,P,PP','97.181417791723','0.0',0.79758169446027915583,1.0037722298893017036,19.864496409364274853,16.290093000647654974,NULL,6,0,'http://lorempixel.com/640/480/fashion','Vero dolores et iusto.','0.462621039926364',NULL,'2019-04-30 03:58:06.2597135',0,NULL);
INSERT INTO StormyProduct VALUES(36,'2019-11-28 15:38:38.9956262+00:00',0,'c9hufkyoiysozpi8','Handmade Steel Cheese','enim-assumenda-accusantium',43,36,0,NULL,NULL,NULL,NULL,94,'GG,G,M,P,PP','20.2348234226158','0.0',0.80968193980384706165,5.2153773993325316382,10.43009798109070374,6.7269091143863786186,NULL,4,1,'http://lorempixel.com/640/480/fashion','Rem temporibus ratione repellendus officiis eius.','0.495077315482813',NULL,'2019-11-06 06:44:14.4430709',0,NULL);
INSERT INTO StormyProduct VALUES(37,'2019-11-28 15:38:38.6049381+00:00',0,'z49lko5qhura7pce','Licensed Rubber Tuna','repellat-suscipit-facilis',57,37,0,NULL,NULL,NULL,NULL,92,'GG,G,M,P,PP','4.38101599196951','0.0',0.76385391725406703855,9.702253621398588379,16.26417010569208088,9.4845457610136580939,NULL,3,1,'http://lorempixel.com/640/480/fashion','Inventore natus incidunt cupiditate sit qui minus omnis.','0.295561941478197',NULL,'2019-03-13 00:38:27.9891941',0,NULL);
INSERT INTO StormyProduct VALUES(38,'2019-11-28 15:38:38.6222669+00:00',0,'uqlooxpzd2n8rw5k','Fantastic Granite Towels','illum-perspiciatis-nemo',55,38,0,NULL,NULL,NULL,NULL,22,'GG,G,M,P,PP','80.940400334513','0.0',0.39258935041380549346,11.292399450341424227,13.710484188380878123,11.805011648593941586,NULL,5,2,'http://lorempixel.com/640/480/fashion','Iusto quaerat adipisci sit.','0.712626167904877',NULL,'2018-12-08 21:58:08.6538633',0,NULL);
INSERT INTO StormyProduct VALUES(39,'2019-11-28 15:38:38.6397904+00:00',0,'93cgp6n2bt52lo5k','Sleek Cotton Cheese','enim-deserunt-est',50,39,0,NULL,NULL,NULL,NULL,40,'GG,G,M,P,PP','61.7892606005954','0.0',0.6396183225510727599,15.674799640977196801,2.7060865609469297865,17.081464094147769117,NULL,9,1,'http://lorempixel.com/640/480/fashion','Autem laborum illum corporis sit saepe laboriosam.','0.735937065321923',NULL,'2019-10-22 21:55:04.7337004',0,NULL);
INSERT INTO StormyProduct VALUES(40,'2019-11-28 15:38:38.6573809+00:00',0,'68u6xi3sbgad5bqm','Licensed Cotton Shirt','modi-eius-et',49,40,0,NULL,NULL,NULL,NULL,44,'GG,G,M,P,PP','51.3373797067149','0.0',0.18406864729899383159,9.6600689029600790291,2.7360395569056454867,12.183651610363112283,NULL,8,0,'http://lorempixel.com/640/480/fashion','Ut est nostrum.','0.742209408312202',NULL,'2019-09-03 10:30:12.7177876',0,NULL);
INSERT INTO StormyProduct VALUES(41,'2019-11-28 15:38:38.6747591+00:00',0,'zhlk6ubq6xpqo94e','Ergonomic Plastic Pants','est-exercitationem-ut',54,41,0,NULL,NULL,NULL,NULL,14,'GG,G,M,P,PP','52.1981612556606','0.0',0.26326316048543113579,11.534997456024866479,12.746238957972376937,15.7580405621593993,NULL,8,0,'http://lorempixel.com/640/480/fashion','Vel neque vero aut perspiciatis molestiae.','0.203043099587338',NULL,'2019-10-09 00:04:10.2862281',0,NULL);
INSERT INTO StormyProduct VALUES(42,'2019-11-28 15:38:38.6922449+00:00',0,'zw5hfdrebvkig2uw','Incredible Soft Gloves','possimus-qui-et',48,42,0,NULL,NULL,NULL,NULL,44,'GG,G,M,P,PP','96.4563327359298','0.0',0.59946433855195735418,12.58314205221046933,15.482041107249465028,15.55600325137190687,NULL,9,2,'http://lorempixel.com/640/480/fashion','Corporis perspiciatis et eum et est corrupti veritatis animi.','0.448214916721086',NULL,'2019-06-24 09:24:32.7964382',0,NULL);
INSERT INTO StormyProduct VALUES(43,'2019-11-28 15:38:38.7095326+00:00',0,'dbdnv6zcylmss6k1','Fantastic Plastic Car','et-ea-nobis',56,43,0,NULL,NULL,NULL,NULL,26,'GG,G,M,P,PP','70.5576558460284','0.0',0.45571937433244630311,6.7491610663706254058,4.7812004349106924649,3.7941118193762894961,NULL,7,1,'http://lorempixel.com/640/480/fashion','Dolore porro et.','0.055572786859969',NULL,'2019-06-03 03:21:06.104479',0,NULL);
INSERT INTO StormyProduct VALUES(44,'2019-11-28 15:38:38.7280296+00:00',0,'busgkl07u1trzbdg','Handcrafted Cotton Table','nemo-ipsum-velit',59,44,0,NULL,NULL,NULL,NULL,46,'GG,G,M,P,PP','59.1385028600406','0.0',0.82819984053643413979,17.49372321716217371,5.1441774559878643557,6.160452974569262885,NULL,10,0,'http://lorempixel.com/640/480/fashion','Quaerat et unde et quo.','0.106950316627952',NULL,'2019-03-30 18:57:02.990996',0,NULL);
INSERT INTO StormyProduct VALUES(45,'2019-11-28 15:38:38.7449499+00:00',0,'ing2ln6q23hc0gqj','Fantastic Fresh Car','voluptatem-error-velit',44,45,0,NULL,NULL,NULL,NULL,74,'GG,G,M,P,PP','46.228855031649','0.0',0.25254888332101932402,4.1449863808904714446,6.8609648364879953774,16.562160235160106935,NULL,4,1,'http://lorempixel.com/640/480/fashion','Aut eligendi deleniti.','0.0198917514737191',NULL,'2019-10-26 16:31:59.0404408',0,NULL);
INSERT INTO StormyProduct VALUES(46,'2019-11-28 15:38:38.7618479+00:00',0,'ybu6r91bwsec8f7z','Awesome Wooden Pants','vel-et-quo',12,46,0,NULL,NULL,NULL,NULL,38,'GG,G,M,P,PP','84.9521377985143','0.0',0.86168253135945760412,11.376985219017129224,19.62560669222176557,14.786086041846353111,NULL,5,2,'http://lorempixel.com/640/480/fashion','Nostrum sed maxime.','0.0983314766075143',NULL,'2019-11-08 21:34:04.5472024',0,NULL);
INSERT INTO StormyProduct VALUES(47,'2019-11-28 15:38:39.4476986+00:00',0,'dr63k3729pvwufqp','Handcrafted Metal Chips','dolorem-aspernatur-et',47,47,0,NULL,NULL,NULL,NULL,20,'GG,G,M,P,PP','84.6217348168705','0.0',0.11662049457273468422,11.401919212845115225,13.154362570100632367,10.051556749293373727,NULL,10,0,'http://lorempixel.com/640/480/fashion','Placeat sint cumque repellendus provident quisquam magnam ea eum.','0.118239412604943',NULL,'2019-09-21 10:02:40.6546303',0,NULL);
INSERT INTO StormyProduct VALUES(48,'2019-11-28 15:38:38.7786829+00:00',0,'rg1c30w9mamqokrf','Handmade Plastic Ball','qui-et-voluptas',14,48,0,NULL,NULL,NULL,NULL,70,'GG,G,M,P,PP','46.1424460849457','0.0',0.64152295032587036693,7.9350239224429346407,17.90072766547125127,6.4435474329830828565,NULL,7,2,'http://lorempixel.com/640/480/fashion','Quos dicta corporis est.','0.939611620241595',NULL,'2019-09-16 14:31:24.1635013',0,NULL);
INSERT INTO StormyProduct VALUES(49,'2019-11-28 15:38:38.8126876+00:00',0,'vgdxj1clp722vtfv','Incredible Granite Chips','autem-quis-debitis',17,49,0,NULL,NULL,NULL,NULL,30,'GG,G,M,P,PP','22.4141771078176','0.0',0.27510010324190375952,15.240018502920875675,17.167024147774569087,6.9157097874748094668,NULL,3,1,'http://lorempixel.com/640/480/fashion','Quis soluta nam et voluptas impedit dolor qui laborum.','0.929049469963205',NULL,'2019-10-29 10:11:54.6027715',0,NULL);
INSERT INTO StormyProduct VALUES(50,'2019-11-28 15:38:38.8301113+00:00',0,'h7eh5mqtw138kpai','Refined Cotton Shoes','et-animi-iure',45,50,0,NULL,NULL,NULL,NULL,6,'GG,G,M,P,PP','17.4206599674284','0.0',0.5134854291162851414,6.5310752999647867511,17.71047512474957486,9.916502446828644679,NULL,9,0,'http://lorempixel.com/640/480/fashion','Consequatur excepturi quaerat hic illum illum.','0.561587344650918',NULL,'2019-09-07 17:00:24.0828954',0,NULL);
INSERT INTO StormyProduct VALUES(51,'2019-11-28 15:38:38.8476698+00:00',0,'yzirpkf9t79s3jwg','Unbranded Rubber Cheese','non-numquam-magni',21,51,0,NULL,NULL,NULL,NULL,4,'GG,G,M,P,PP','89.1281066877433','0.0',0.6096975936599530188,8.4583532197672646191,10.628106341058437322,2.9288632971834687168,NULL,6,2,'http://lorempixel.com/640/480/fashion','Sint ut numquam necessitatibus maxime natus quibusdam sint delectus.','0.0303471996590249',NULL,'2019-02-28 00:26:42.1569546',0,NULL);
INSERT INTO StormyProduct VALUES(52,'2019-11-28 15:38:38.8710346+00:00',0,'434wbls23r32ebf3','Gorgeous Steel Bacon','deserunt-ullam-et',23,52,0,NULL,NULL,NULL,NULL,34,'GG,G,M,P,PP','6.36649835219909','0.0',0.86874744988453922456,12.746568706699910933,1.3604190220872030003,2.5933997154205101765,NULL,9,0,'http://lorempixel.com/640/480/fashion','Rem exercitationem ut dolor qui occaecati debitis dicta.','0.469189313458833',NULL,'2018-12-28 05:15:01.5907614',0,NULL);
INSERT INTO StormyProduct VALUES(53,'2019-11-28 15:38:38.8885935+00:00',0,'8djpwckk6rlcitzv','Tasty Metal Tuna','aliquid-voluptas-iusto',24,53,0,NULL,NULL,NULL,NULL,2,'GG,G,M,P,PP','84.7803679224012','0.0',0.59573831856052317235,12.804781380949906477,7.1546075116631611123,2.6308531014392402269,NULL,10,0,'http://lorempixel.com/640/480/fashion','Voluptatum eos sit doloribus aut.','0.659704196108367',NULL,'2019-04-09 00:52:03.7844553',0,NULL);
INSERT INTO StormyProduct VALUES(54,'2019-11-28 15:38:38.9063482+00:00',0,'6fc5dyarwi8lqd61','Awesome Fresh Ball','molestiae-autem-suscipit',26,54,0,NULL,NULL,NULL,NULL,46,'GG,G,M,P,PP','94.2849095418514','0.0',0.43050678373803702436,17.153182478227272156,18.910875015850585612,2.5914934191813197017,NULL,8,1,'http://lorempixel.com/640/480/fashion','Fuga sed possimus ut.','0.477021393588288',NULL,'2019-03-12 09:16:30.729627',0,NULL);
INSERT INTO StormyProduct VALUES(55,'2019-11-28 15:38:38.9243362+00:00',0,'cohc8ydhb0trwesz','Incredible Fresh Sausages','cum-deserunt-eum',28,55,0,NULL,NULL,NULL,NULL,74,'GG,G,M,P,PP','30.1317947591337','0.0',0.66427651218337779859,9.6195751841271182058,6.6565820982943204597,2.5898746245493526885,NULL,10,2,'http://lorempixel.com/640/480/fashion','Atque facere et dicta nihil a necessitatibus cum dicta.','0.309013700256596',NULL,'2019-11-02 06:31:17.3741038',0,NULL);
INSERT INTO StormyProduct VALUES(56,'2019-11-28 15:38:38.9414288+00:00',0,'h4651ysxqruizi89','Fantastic Metal Car','repellat-hic-aliquam',42,56,0,NULL,NULL,NULL,NULL,24,'GG,G,M,P,PP','96.1298287362465','0.0',0.38153542363156350836,10.649315625265852958,1.0571339261052823399,19.243805362956507565,NULL,7,1,'http://lorempixel.com/640/480/fashion','Et sapiente vel ut ullam aut.','0.430041162497383',NULL,'2019-07-25 16:43:55.8874674',0,NULL);
INSERT INTO StormyProduct VALUES(57,'2019-11-28 15:38:38.9590453+00:00',0,'i4qv4nr9d3djbcx1','Gorgeous Wooden Cheese','eum-dolore-et',41,57,0,NULL,NULL,NULL,NULL,90,'GG,G,M,P,PP','80.3796482646743','0.0',0.77042633470633359316,10.640795544553919071,7.0033116643332462558,1.2571062330422486663,NULL,4,1,'http://lorempixel.com/640/480/fashion','Excepturi aut quia.','0.349350072606164',NULL,'2019-01-30 12:52:08.7687616',0,NULL);
INSERT INTO StormyProduct VALUES(58,'2019-11-28 15:38:38.9778281+00:00',0,'axhbfaac22jvg6sk','Incredible Cotton Towels','illum-error-quae',38,58,0,NULL,NULL,NULL,NULL,58,'GG,G,M,P,PP','76.0501474496211','0.0',0.29270698330025513023,13.677657804301780686,4.1056400230646321602,9.263633985195138365,NULL,9,0,'http://lorempixel.com/640/480/fashion','Molestiae qui tempora consectetur voluptates porro sed.','0.824374340392824',NULL,'2019-05-05 22:13:38.0401544',0,NULL);
INSERT INTO StormyProduct VALUES(59,'2019-11-28 15:38:38.7957019+00:00',0,'3jen40xxp5gmbu6l','Generic Rubber Fish','quo-molestiae-ratione',16,59,0,NULL,NULL,NULL,NULL,54,'GG,G,M,P,PP','9.10073477267322','0.0',0.58794535584186458088,15.816331997428243027,9.5369830636945476243,1.3260705561032848365,NULL,2,1,'http://lorempixel.com/640/480/fashion','Quos molestias porro ipsam.','0.288263939455274',NULL,'2019-04-14 19:59:05.1483185',0,NULL);
INSERT INTO StormyProduct VALUES(60,'2019-11-28 15:38:39.4647608+00:00',0,'uzcsln9i0gu7cpjo','Incredible Cotton Ball','ut-fugit-dolores',52,60,0,NULL,NULL,NULL,NULL,32,'GG,G,M,P,PP','96.4414741361707','0.0',0.24583276232976128405,14.376329655934279472,4.1011028327518621594,2.8356831990348561056,NULL,9,0,'http://lorempixel.com/640/480/fashion','Reprehenderit quam optio omnis perferendis iste animi eos delectus et.','0.686173541325225',NULL,'2019-05-16 18:20:56.9489395',0,NULL);
CREATE TABLE IF NOT EXISTS "ProductAttributeValue" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_ProductAttributeValue" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "AttributeId" INTEGER NOT NULL,
    "ProductId" INTEGER NOT NULL,
    "Value" TEXT NULL,
    CONSTRAINT "FK_ProductAttributeValue_ProductAttribute_AttributeId" FOREIGN KEY ("AttributeId") REFERENCES "ProductAttribute" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductAttributeValue_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS "ProductCategory" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_ProductCategory" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "DisplayOrder" INTEGER NOT NULL,
    "CategoryId" INTEGER NOT NULL,
    "ProductId" INTEGER NOT NULL,
    CONSTRAINT "FK_ProductCategory_Category_CategoryId" FOREIGN KEY ("CategoryId") REFERENCES "Category" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_ProductCategory_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT
);
INSERT INTO ProductCategory VALUES(1,'2019-11-28 15:38:37.0523346+00:00',0,51,8,1);
INSERT INTO ProductCategory VALUES(2,'2019-11-28 15:38:37.6365536+00:00',0,41,1,9);
INSERT INTO ProductCategory VALUES(3,'2019-11-28 15:38:37.1399336+00:00',0,36,6,2);
INSERT INTO ProductCategory VALUES(4,'2019-11-28 15:38:37.5574227+00:00',0,76,5,8);
INSERT INTO ProductCategory VALUES(5,'2019-11-28 15:38:37.2084442+00:00',0,12,3,3);
INSERT INTO ProductCategory VALUES(6,'2019-11-28 15:38:37.4872587+00:00',0,18,2,7);
INSERT INTO ProductCategory VALUES(7,'2019-11-28 15:38:37.2765196+00:00',0,31,10,4);
INSERT INTO ProductCategory VALUES(8,'2019-11-28 15:38:37.4165707+00:00',0,25,9,6);
INSERT INTO ProductCategory VALUES(9,'2019-11-28 15:38:37.3459877+00:00',0,37,4,5);
INSERT INTO ProductCategory VALUES(10,'2019-11-28 15:38:37.7220651+00:00',0,17,7,10);
INSERT INTO ProductCategory VALUES(11,'2019-11-28 15:38:38.6014622+00:00',0,102,31,11);
INSERT INTO ProductCategory VALUES(12,'2019-11-28 15:38:39.3420455+00:00',0,65,50,26);
INSERT INTO ProductCategory VALUES(13,'2019-11-28 15:38:39.1898117+00:00',0,96,35,17);
INSERT INTO ProductCategory VALUES(14,'2019-11-28 15:38:38.9028684+00:00',0,97,53,53);
INSERT INTO ProductCategory VALUES(15,'2019-11-28 15:38:39.3252804+00:00',0,69,17,25);
INSERT INTO ProductCategory VALUES(16,'2019-11-28 15:38:38.9208693+00:00',0,77,47,54);
INSERT INTO ProductCategory VALUES(17,'2019-11-28 15:38:38.9379675+00:00',0,54,16,55);
INSERT INTO ProductCategory VALUES(18,'2019-11-28 15:38:39.3085173+00:00',0,55,15,24);
INSERT INTO ProductCategory VALUES(19,'2019-11-28 15:38:38.9554654+00:00',0,49,12,56);
INSERT INTO ProductCategory VALUES(20,'2019-11-28 15:38:38.9739239+00:00',0,9,14,57);
INSERT INTO ProductCategory VALUES(21,'2019-11-28 15:38:39.2916209+00:00',0,57,19,23);
INSERT INTO ProductCategory VALUES(22,'2019-11-28 15:38:38.9917465+00:00',0,81,33,58);
INSERT INTO ProductCategory VALUES(23,'2019-11-28 15:38:39.009036+00:00',0,22,20,36);
INSERT INTO ProductCategory VALUES(24,'2019-11-28 15:38:39.2745374+00:00',0,104,59,22);
INSERT INTO ProductCategory VALUES(25,'2019-11-28 15:38:39.0268489+00:00',0,54,23,35);
INSERT INTO ProductCategory VALUES(26,'2019-11-28 15:38:39.479347+00:00',0,84,30,60);
INSERT INTO ProductCategory VALUES(27,'2019-11-28 15:38:39.0445232+00:00',0,62,26,34);
INSERT INTO ProductCategory VALUES(28,'2019-11-28 15:38:39.062374+00:00',0,10,29,33);
INSERT INTO ProductCategory VALUES(29,'2019-11-28 15:38:39.2578384+00:00',0,15,39,21);
INSERT INTO ProductCategory VALUES(30,'2019-11-28 15:38:39.0804902+00:00',0,10,32,12);
INSERT INTO ProductCategory VALUES(31,'2019-11-28 15:38:39.0981526+00:00',0,17,57,13);
INSERT INTO ProductCategory VALUES(32,'2019-11-28 15:38:39.2409771+00:00',0,44,41,20);
INSERT INTO ProductCategory VALUES(33,'2019-11-28 15:38:39.1157901+00:00',0,30,27,14);
INSERT INTO ProductCategory VALUES(34,'2019-11-28 15:38:39.1337607+00:00',0,38,22,15);
INSERT INTO ProductCategory VALUES(35,'2019-11-28 15:38:39.2237221+00:00',0,16,45,19);
INSERT INTO ProductCategory VALUES(36,'2019-11-28 15:38:39.1521004+00:00',0,20,11,16);
INSERT INTO ProductCategory VALUES(37,'2019-11-28 15:38:38.8675566+00:00',0,67,58,51);
INSERT INTO ProductCategory VALUES(38,'2019-11-28 15:38:38.8438908+00:00',0,99,49,50);
INSERT INTO ProductCategory VALUES(39,'2019-11-28 15:38:38.885135+00:00',0,72,55,52);
INSERT INTO ProductCategory VALUES(40,'2019-11-28 15:38:39.2068752+00:00',0,85,60,18);
INSERT INTO ProductCategory VALUES(41,'2019-11-28 15:38:38.6539618+00:00',0,66,13,39);
INSERT INTO ProductCategory VALUES(42,'2019-11-28 15:38:38.688509+00:00',0,74,56,41);
INSERT INTO ProductCategory VALUES(43,'2019-11-28 15:38:39.4273703+00:00',0,66,46,31);
INSERT INTO ProductCategory VALUES(44,'2019-11-28 15:38:38.7058952+00:00',0,101,48,42);
INSERT INTO ProductCategory VALUES(45,'2019-11-28 15:38:39.3591163+00:00',0,60,24,27);
INSERT INTO ProductCategory VALUES(46,'2019-11-28 15:38:38.7244493+00:00',0,24,42,43);
INSERT INTO ProductCategory VALUES(47,'2019-11-28 15:38:39.4103161+00:00',0,32,52,30);
INSERT INTO ProductCategory VALUES(48,'2019-11-28 15:38:38.7414233+00:00',0,58,37,44);
INSERT INTO ProductCategory VALUES(49,'2019-11-28 15:38:38.6363679+00:00',0,55,21,38);
INSERT INTO ProductCategory VALUES(50,'2019-11-28 15:38:38.6713401+00:00',0,96,36,40);
INSERT INTO ProductCategory VALUES(51,'2019-11-28 15:38:39.4442463+00:00',0,46,34,32);
INSERT INTO ProductCategory VALUES(52,'2019-11-28 15:38:39.3932515+00:00',0,48,18,29);
INSERT INTO ProductCategory VALUES(53,'2019-11-28 15:38:38.7751763+00:00',0,36,40,46);
INSERT INTO ProductCategory VALUES(54,'2019-11-28 15:38:39.461291+00:00',0,101,54,47);
INSERT INTO ProductCategory VALUES(55,'2019-11-28 15:38:38.6188012+00:00',0,103,25,37);
INSERT INTO ProductCategory VALUES(56,'2019-11-28 15:38:38.7920042+00:00',0,37,43,48);
INSERT INTO ProductCategory VALUES(57,'2019-11-28 15:38:39.3761576+00:00',0,43,28,28);
INSERT INTO ProductCategory VALUES(58,'2019-11-28 15:38:38.8091577+00:00',0,59,44,59);
INSERT INTO ProductCategory VALUES(59,'2019-11-28 15:38:38.8264259+00:00',0,1,51,49);
INSERT INTO ProductCategory VALUES(60,'2019-11-28 15:38:38.7583091+00:00',0,79,38,45);
CREATE TABLE IF NOT EXISTS "ProductLink" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_ProductLink" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "ProductId" INTEGER NOT NULL,
    "LinkedProductId" INTEGER NOT NULL,
    "LinkType" INTEGER NOT NULL,
    CONSTRAINT "FK_ProductLink_StormyProduct_LinkedProductId" FOREIGN KEY ("LinkedProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductLink_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT
);
CREATE TABLE IF NOT EXISTS "ProductMedia" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_ProductMedia" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "MediaId" INTEGER NOT NULL,
    "StormyProductId" INTEGER NOT NULL,
    CONSTRAINT "FK_ProductMedia_Media_MediaId" FOREIGN KEY ("MediaId") REFERENCES "Media" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_ProductMedia_StormyProduct_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT
);
INSERT INTO ProductMedia VALUES(1,'2019-11-28 15:38:37.3420253+00:00',0,6,5);
INSERT INTO ProductMedia VALUES(2,'2019-11-28 15:38:37.6325429+00:00',0,7,9);
INSERT INTO ProductMedia VALUES(3,'2019-11-28 15:38:37.553728+00:00',0,1,8);
INSERT INTO ProductMedia VALUES(4,'2019-11-28 15:38:37.4835093+00:00',0,2,7);
INSERT INTO ProductMedia VALUES(5,'2019-11-28 15:38:37.4127728+00:00',0,4,6);
INSERT INTO ProductMedia VALUES(6,'2019-11-28 15:38:37.7186538+00:00',0,5,10);
INSERT INTO ProductMedia VALUES(7,'2019-11-28 15:38:37.272235+00:00',0,3,4);
INSERT INTO ProductMedia VALUES(8,'2019-11-28 15:38:37.2047518+00:00',0,8,3);
INSERT INTO ProductMedia VALUES(9,'2019-11-28 15:38:37.1361756+00:00',0,9,2);
INSERT INTO ProductMedia VALUES(10,'2019-11-28 15:38:37.045173+00:00',0,10,1);
INSERT INTO ProductMedia VALUES(11,'2019-11-28 15:38:39.4411751+00:00',0,32,32);
INSERT INTO ProductMedia VALUES(12,'2019-11-28 15:38:39.457984+00:00',0,37,47);
INSERT INTO ProductMedia VALUES(13,'2019-11-28 15:38:39.2038775+00:00',0,18,18);
INSERT INTO ProductMedia VALUES(14,'2019-11-28 15:38:39.2380197+00:00',0,15,20);
INSERT INTO ProductMedia VALUES(15,'2019-11-28 15:38:39.2207315+00:00',0,20,19);
INSERT INTO ProductMedia VALUES(16,'2019-11-28 15:38:39.4072114+00:00',0,59,30);
INSERT INTO ProductMedia VALUES(17,'2019-11-28 15:38:39.2548193+00:00',0,23,21);
INSERT INTO ProductMedia VALUES(18,'2019-11-28 15:38:39.2716018+00:00',0,13,22);
INSERT INTO ProductMedia VALUES(19,'2019-11-28 15:38:39.3901008+00:00',0,25,29);
INSERT INTO ProductMedia VALUES(20,'2019-11-28 15:38:39.2886301+00:00',0,17,23);
INSERT INTO ProductMedia VALUES(21,'2019-11-28 15:38:39.3055682+00:00',0,55,24);
INSERT INTO ProductMedia VALUES(22,'2019-11-28 15:38:39.373121+00:00',0,50,28);
INSERT INTO ProductMedia VALUES(23,'2019-11-28 15:38:39.3223496+00:00',0,22,25);
INSERT INTO ProductMedia VALUES(24,'2019-11-28 15:38:39.3560721+00:00',0,12,27);
INSERT INTO ProductMedia VALUES(25,'2019-11-28 15:38:39.424227+00:00',0,27,31);
INSERT INTO ProductMedia VALUES(26,'2019-11-28 15:38:39.3390484+00:00',0,19,26);
INSERT INTO ProductMedia VALUES(27,'2019-11-28 15:38:39.0234644+00:00',0,49,35);
INSERT INTO ProductMedia VALUES(28,'2019-11-28 15:38:39.1488778+00:00',0,16,16);
INSERT INTO ProductMedia VALUES(29,'2019-11-28 15:38:38.5984416+00:00',0,41,11);
INSERT INTO ProductMedia VALUES(30,'2019-11-28 15:38:38.6157037+00:00',0,40,37);
INSERT INTO ProductMedia VALUES(31,'2019-11-28 15:38:38.6334063+00:00',0,39,38);
INSERT INTO ProductMedia VALUES(32,'2019-11-28 15:38:38.6509956+00:00',0,38,39);
INSERT INTO ProductMedia VALUES(33,'2019-11-28 15:38:38.6683731+00:00',0,36,40);
INSERT INTO ProductMedia VALUES(34,'2019-11-28 15:38:38.6855007+00:00',0,35,41);
INSERT INTO ProductMedia VALUES(35,'2019-11-28 15:38:38.7028274+00:00',0,34,42);
INSERT INTO ProductMedia VALUES(36,'2019-11-28 15:38:38.7214718+00:00',0,33,43);
INSERT INTO ProductMedia VALUES(37,'2019-11-28 15:38:38.7384346+00:00',0,31,44);
INSERT INTO ProductMedia VALUES(38,'2019-11-28 15:38:38.7553574+00:00',0,30,45);
INSERT INTO ProductMedia VALUES(39,'2019-11-28 15:38:38.772201+00:00',0,29,46);
INSERT INTO ProductMedia VALUES(40,'2019-11-28 15:38:38.7890383+00:00',0,28,48);
INSERT INTO ProductMedia VALUES(41,'2019-11-28 15:38:38.8060754+00:00',0,42,59);
INSERT INTO ProductMedia VALUES(42,'2019-11-28 15:38:38.8230659+00:00',0,44,49);
INSERT INTO ProductMedia VALUES(43,'2019-11-28 15:38:39.186474+00:00',0,14,17);
INSERT INTO ProductMedia VALUES(44,'2019-11-28 15:38:38.8405794+00:00',0,43,50);
INSERT INTO ProductMedia VALUES(45,'2019-11-28 15:38:38.8820783+00:00',0,58,52);
INSERT INTO ProductMedia VALUES(46,'2019-11-28 15:38:38.899875+00:00',0,57,53);
INSERT INTO ProductMedia VALUES(47,'2019-11-28 15:38:38.9178296+00:00',0,56,54);
INSERT INTO ProductMedia VALUES(48,'2019-11-28 15:38:38.9349931+00:00',0,60,55);
INSERT INTO ProductMedia VALUES(49,'2019-11-28 15:38:38.9524161+00:00',0,54,56);
INSERT INTO ProductMedia VALUES(50,'2019-11-28 15:38:38.9709575+00:00',0,45,57);
INSERT INTO ProductMedia VALUES(51,'2019-11-28 15:38:38.9886352+00:00',0,52,58);
INSERT INTO ProductMedia VALUES(52,'2019-11-28 15:38:39.0058879+00:00',0,51,36);
INSERT INTO ProductMedia VALUES(53,'2019-11-28 15:38:39.0406855+00:00',0,47,34);
INSERT INTO ProductMedia VALUES(54,'2019-11-28 15:38:39.058682+00:00',0,46,33);
INSERT INTO ProductMedia VALUES(55,'2019-11-28 15:38:39.0773455+00:00',0,26,12);
INSERT INTO ProductMedia VALUES(56,'2019-11-28 15:38:39.0950507+00:00',0,11,13);
INSERT INTO ProductMedia VALUES(57,'2019-11-28 15:38:39.1126108+00:00',0,21,14);
INSERT INTO ProductMedia VALUES(58,'2019-11-28 15:38:39.13056+00:00',0,24,15);
INSERT INTO ProductMedia VALUES(59,'2019-11-28 15:38:38.8643021+00:00',0,53,51);
INSERT INTO ProductMedia VALUES(60,'2019-11-28 15:38:39.4751405+00:00',0,48,60);
CREATE TABLE IF NOT EXISTS "ProductOptionCombination" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_ProductOptionCombination" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "ProductId" INTEGER NOT NULL,
    "OptionId" INTEGER NOT NULL,
    "Value" TEXT NULL,
    "SortIndex" INTEGER NOT NULL,
    CONSTRAINT "FK_ProductOptionCombination_ProductOption_OptionId" FOREIGN KEY ("OptionId") REFERENCES "ProductOption" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductOptionCombination_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS "ProductOptionValue" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_ProductOptionValue" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "OptionId" INTEGER NOT NULL,
    "ProductId" INTEGER NOT NULL,
    "Value" TEXT NULL,
    "DisplayType" TEXT NULL,
    "SortIndex" INTEGER NOT NULL,
    CONSTRAINT "FK_ProductOptionValue_ProductOption_OptionId" FOREIGN KEY ("OptionId") REFERENCES "ProductOption" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductOptionValue_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS "ProductTemplate" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_ProductTemplate" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "Name" TEXT NULL,
    "StormyProductId" INTEGER NOT NULL,
    CONSTRAINT "FK_ProductTemplate_StormyProduct_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS "WishlistItem" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_WishlistItem" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "ProductId" INTEGER NOT NULL,
    "WishlistId" INTEGER NOT NULL,
    "AddedAt" TEXT NOT NULL,
    "WishlistId1" INTEGER NULL,
    CONSTRAINT "FK_WishlistItem_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_WishlistItem_Wishlist_WishlistId" FOREIGN KEY ("WishlistId") REFERENCES "Wishlist" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_WishlistItem_Wishlist_WishlistId1" FOREIGN KEY ("WishlistId1") REFERENCES "Wishlist" ("Id") ON DELETE RESTRICT
);
CREATE TABLE IF NOT EXISTS "ProductTemplateProductAttribute" (
    "ProductTemplateId" INTEGER NOT NULL,
    "ProductAttributeId" INTEGER NOT NULL,
    CONSTRAINT "PK_ProductTemplateProductAttribute" PRIMARY KEY ("ProductTemplateId", "ProductAttributeId"),
    CONSTRAINT "FK_ProductTemplateProductAttribute_ProductAttribute_ProductAttributeId" FOREIGN KEY ("ProductAttributeId") REFERENCES "ProductAttribute" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_ProductTemplateProductAttribute_ProductTemplate_ProductTemplateId" FOREIGN KEY ("ProductTemplateId") REFERENCES "ProductTemplate" ("Id") ON DELETE RESTRICT
);
CREATE TABLE IF NOT EXISTS "StormyCustomer" (
    "Id" TEXT NOT NULL CONSTRAINT "PK_StormyCustomer" PRIMARY KEY,
    "UserName" TEXT NULL,
    "NormalizedUserName" TEXT NULL,
    "Email" TEXT NOT NULL,
    "NormalizedEmail" TEXT NULL,
    "EmailConfirmed" INTEGER NOT NULL,
    "PasswordHash" TEXT NULL,
    "SecurityStamp" TEXT NULL,
    "ConcurrencyStamp" TEXT NULL,
    "PhoneNumber" TEXT NULL,
    "PhoneNumberConfirmed" INTEGER NOT NULL,
    "TwoFactorEnabled" INTEGER NOT NULL,
    "LockoutEnd" TEXT NULL,
    "LockoutEnabled" INTEGER NOT NULL,
    "AccessFailedCount" INTEGER NOT NULL,
    "CPF" TEXT NULL,
    "DefaultShippingAddressId" INTEGER NULL,
    "DefaultBillingAddressId" INTEGER NULL,
    "CustomerReviewsId" INTEGER NULL,
    "CustomerWishlistId" INTEGER NULL,
    "CustomerWishlistId1" INTEGER NULL,
    "FullName" TEXT NULL,
    "RefreshTokenHash" TEXT NULL,
    "DateOfBirth" TEXT NULL,
    "RoleId" TEXT NULL,
    "CreatedOn" TEXT NOT NULL,
    CONSTRAINT "FK_StormyCustomer_Wishlist_CustomerWishlistId" FOREIGN KEY ("CustomerWishlistId") REFERENCES "Wishlist" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_StormyCustomer_Wishlist_CustomerWishlistId1" FOREIGN KEY ("CustomerWishlistId1") REFERENCES "Wishlist" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_StormyCustomer_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES "AspNetRoles" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_StormyCustomer_CustomerAddress_DefaultBillingAddressId" FOREIGN KEY ("DefaultBillingAddressId") REFERENCES "CustomerAddress" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_StormyCustomer_CustomerAddress_DefaultShippingAddressId" FOREIGN KEY ("DefaultShippingAddressId") REFERENCES "CustomerAddress" ("Id") ON DELETE RESTRICT
);
INSERT INTO StormyCustomer VALUES('26aa9077-1f6e-4e65-9087-42ce895f59aa','Elaina.Shanahan12',NULL,'Cindy77@hotmail.com',NULL,1,NULL,NULL,'e13f2384-d319-4f47-a68d-f4930e5d42c7','751.704.8762 x935',1,0,NULL,0,0,'000000000',18,19,NULL,NULL,10,NULL,NULL,NULL,NULL,'2019-11-28 15:38:36.9485302+00:00');
INSERT INTO StormyCustomer VALUES('69325532-679b-45d9-96ce-71100b12d860','Cheyenne.Hodkiewicz9',NULL,'Tomasa.Goodwin55@gmail.com',NULL,1,NULL,NULL,'bc67e916-5dd7-47e5-acca-227d0ce56dc3','542.847.7760',1,0,NULL,0,0,'000000000',15,16,NULL,NULL,8,NULL,NULL,NULL,NULL,'2019-11-28 15:38:37.1084558+00:00');
INSERT INTO StormyCustomer VALUES('5d03ad70-499f-4328-af81-4df024d7a3ab','Adrianna45',NULL,'Hilbert.Emard@yahoo.com',NULL,1,NULL,NULL,'3dcaa607-a963-48ad-bf50-44d6679c0ca3','1-676-388-2019 x0830',1,0,NULL,0,0,'000000000',1,7,NULL,NULL,2,NULL,NULL,NULL,NULL,'2019-11-28 15:38:37.6008572+00:00');
INSERT INTO StormyCustomer VALUES('dd1dd750-375c-4b2b-9b56-fd9de890b3cc','Brandt_Spinka',NULL,'Lelah55@yahoo.com',NULL,1,NULL,NULL,'a93429f8-0e5c-4251-b4f7-f8197f8733b3','(630) 494-3133 x120',1,0,NULL,0,0,'000000000',11,12,NULL,NULL,7,NULL,NULL,NULL,NULL,'2019-11-28 15:38:37.1769741+00:00');
INSERT INTO StormyCustomer VALUES('3776071a-0e8a-4bd6-8fb6-fa5fc13b6d83','Kenya_Lynch19',NULL,'Alexys.Stehr14@gmail.com',NULL,1,NULL,NULL,'24930c94-0135-4057-b6ab-5d4a77fe1ddd','(884) 751-1849 x88809',1,0,NULL,0,0,'000000000',8,9,NULL,NULL,5,NULL,NULL,NULL,NULL,'2019-11-28 15:38:37.2447757+00:00');
INSERT INTO StormyCustomer VALUES('927332b2-24dc-41c6-a550-70cc5833ed6b','Terrill.Kunze77',NULL,'Ona65@gmail.com',NULL,1,NULL,NULL,'9cbf3207-d60e-4d54-8d9e-576f48774ed6','1-541-926-3433',1,0,NULL,0,0,'000000000',20,17,NULL,NULL,9,NULL,NULL,NULL,NULL,'2019-11-28 15:38:37.5249702+00:00');
INSERT INTO StormyCustomer VALUES('1d10464a-bd47-4030-b21d-52a9934ca862','Howell24',NULL,'Arch_Collier@hotmail.com',NULL,1,NULL,NULL,'2d839441-f37a-447f-9f46-0fe9587ddcfc','1-606-709-2536 x28368',1,0,NULL,0,0,'000000000',3,4,NULL,NULL,4,NULL,NULL,NULL,NULL,'2019-11-28 15:38:37.3134984+00:00');
INSERT INTO StormyCustomer VALUES('1a64b35c-5920-42cc-9a9c-88e6a71347d9','Winifred.Rowe26',NULL,'Darren_Spinka@yahoo.com',NULL,1,NULL,NULL,'96214bc2-273e-4e80-be85-5241a9bfb607','533.350.3302',1,0,NULL,0,0,'000000000',14,13,NULL,NULL,6,NULL,NULL,NULL,NULL,'2019-11-28 15:38:37.6946113+00:00');
INSERT INTO StormyCustomer VALUES('4035f1a3-e7b5-4b00-ad72-80c55a61fe15','Myrtie26',NULL,'Hortense_Okuneva92@yahoo.com',NULL,1,NULL,NULL,'6aadf4d4-4a1c-4e96-b020-a97634114acb','(486) 860-0348 x342',1,0,NULL,0,0,'000000000',5,2,NULL,NULL,3,NULL,NULL,NULL,NULL,'2019-11-28 15:38:37.3841388+00:00');
INSERT INTO StormyCustomer VALUES('2670103c-6fef-4bd5-ac1d-21dc5d7b813d','Theresia.Kirlin',NULL,'Lelah.Bernhard38@yahoo.com',NULL,1,NULL,NULL,'eee4f9df-d46d-435a-948e-d04d61a31f54','(873) 989-2406 x5294',1,0,NULL,0,0,'000000000',6,10,NULL,NULL,1,NULL,NULL,NULL,NULL,'2019-11-28 15:38:37.4548296+00:00');
INSERT INTO StormyCustomer VALUES('9ac249bc-1faf-4854-8860-608c4d112fbc','stormyadmin','STORMYADMIN','stormycommerce@gmail.com','STORMYCOMMERCE@GMAIL.COM',1,'AQAAAAEAACcQAAAAEMPfLxuzmMlpbbkCQ+M0vTafCJm0uZsBjiz+LrM0BJ6tDlIrwTkg08699YrDxbv/Pg==','VP4CMVH3VOYYIMLERS2ENL4X3GSPXB5F','2af31517-1121-416f-a384-41bbd7b845da',NULL,0,0,NULL,1,0,NULL,22,21,NULL,NULL,11,NULL,NULL,NULL,'9bbc7c4a-481c-4434-b890-44e0686d9820','0001-01-01 00:00:00+00:00');
INSERT INTO StormyCustomer VALUES('d32919c3-26ce-4634-aa90-31d8ae2091ee','stormydev','STORMYDEV','adnangonzaga@gmail.com','ADNANGONZAGA@GMAIL.COM',1,'AQAAAAEAACcQAAAAEHJBPz9+n/OznY5v00ptoH7qW0RakVnNMzSkDU+dDVehYw3Qdh0fkrzD7XfO8j19xg==','YNKEOWBYX3VJUXEBEAHUSOAKNEZHOODB','ac5e50ff-cc47-4945-9087-ee36b80a1dbd','+5511992887102',0,0,NULL,1,0,'10172930820',24,23,NULL,NULL,12,'Severino Francisco Daniel da Rocha',NULL,'2001-11-01 00:00:00-02:00','6562c52b-801f-4a43-a20b-956c4341adc1','0001-01-01 00:00:00+00:00');
CREATE TABLE IF NOT EXISTS "Comment" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Comment" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "Title" TEXT NOT NULL,
    "Body" TEXT NULL,
    "ProductId" INTEGER NOT NULL,
    "StormyCustomerId" TEXT NULL,
    CONSTRAINT "FK_Comment_StormyProduct_ProductId" FOREIGN KEY ("ProductId") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_Comment_StormyCustomer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE RESTRICT
);
CREATE TABLE IF NOT EXISTS "CustomerAddress" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_CustomerAddress" PRIMARY KEY AUTOINCREMENT,
    "Street" TEXT NULL,
    "FirstAddress" TEXT NULL,
    "SecondAddress" TEXT NULL,
    "City" TEXT NULL,
    "District" TEXT NULL,
    "State" TEXT NULL,
    "PostalCode" TEXT NULL,
    "Number" TEXT NULL,
    "Complement" TEXT NULL,
    "Country" TEXT NULL,
    "WhoReceives" TEXT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "UserId" TEXT NULL,
    "OwnerId" TEXT NULL,
    CONSTRAINT "FK_CustomerAddress_StormyCustomer_OwnerId" FOREIGN KEY ("OwnerId") REFERENCES "StormyCustomer" ("Id") ON DELETE RESTRICT
);
INSERT INTO CustomerAddress VALUES(1,'Pablo Viela',NULL,NULL,NULL,'Avenida','Mato Grosso','63698-142','8621','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(2,'Ofélia Alameda',NULL,NULL,NULL,'Avenida','São Paulo','75975-075','908','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(3,'Eduardo Rodovia',NULL,NULL,NULL,'Avenida','Rondônia','23763-600','13429','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(4,'Martins Marginal',NULL,NULL,NULL,'Travessa','Pernambuco','82037-636','007','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(5,'Santos Marginal',NULL,NULL,NULL,'Viela','Rio Grande do Sul','24486','8013','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(6,'Carvalho Marginal',NULL,NULL,NULL,'Rua','Bahia','57808','67990','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(7,'Reis Marginal',NULL,NULL,NULL,'Viela','Rio Grande do Norte','24155','55617','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(8,'Joana Marginal',NULL,NULL,NULL,'Viela','Santa Catarina','34618','395','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(9,'Suélen Viela',NULL,NULL,NULL,'Viela','Rondônia','87000-746','301','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(10,'Pablo Rua',NULL,NULL,NULL,'Marginal','Maranhão','58059-852','19558','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(11,'Ladislau Viela',NULL,NULL,NULL,'Marginal','Piauí','94900','64952','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(12,'Karla Avenida',NULL,NULL,NULL,'Rodovia','Pernambuco','24323','916','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(13,'Moreira Ponte',NULL,NULL,NULL,'Rua','Santa Catarina','39612-905','044','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(14,'Silva Ponte',NULL,NULL,NULL,'Marginal','Santa Catarina','93856-743','095','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(15,'Souza Rodovia',NULL,NULL,NULL,'Rua','Maranhão','25058','731','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(16,'Braga Ponte',NULL,NULL,NULL,'Rodovia','Pernambuco','54324-520','586','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(17,'Nogueira Viela',NULL,NULL,NULL,'Marginal','Santa Catarina','70444','55845','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(18,'Moreira Travessa',NULL,NULL,NULL,'Avenida','Sergipe','47359','943','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(19,'Janaína Travessa',NULL,NULL,NULL,'Alameda','Amazonas','45971','615','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(20,'Santos Ponte',NULL,NULL,NULL,'Ponte','Distrito Federal','70816','723','no complement',NULL,NULL,0,NULL,NULL);
INSERT INTO CustomerAddress VALUES(21,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,'9ac249bc-1faf-4854-8860-608c4d112fbc',NULL);
INSERT INTO CustomerAddress VALUES(22,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,'9ac249bc-1faf-4854-8860-608c4d112fbc',NULL);
INSERT INTO CustomerAddress VALUES(23,'Rua Bento Correia de Figueiredo','Jardim Ipanema (Zona Sul)','Rua Bento Correia de Figueiredo','São Paulo','Jardim Ipanema (Zona Sul)','São Paulo','04784110','640','complemento','br',NULL,0,'d32919c3-26ce-4634-aa90-31d8ae2091ee',NULL);
INSERT INTO CustomerAddress VALUES(24,'Rua Bento Correia de Figueiredo','Jardim Ipanema (Zona Sul)','Rua Bento Correia de Figueiredo','São Paulo','Jardim Ipanema (Zona Sul)','São Paulo','04784110','640','complemento','br',NULL,0,'d32919c3-26ce-4634-aa90-31d8ae2091ee',NULL);
CREATE TABLE IF NOT EXISTS "Review" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Review" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "StormyCustomerId" TEXT NOT NULL,
    "StormyProductId" INTEGER NOT NULL,
    "Title" TEXT NULL,
    "Comment" TEXT NULL,
    "ReviewerName" TEXT NULL,
    "RatingLevel" INTEGER NOT NULL,
    "Status" INTEGER NOT NULL,
    CONSTRAINT "FK_Review_StormyCustomer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Review_StormyProduct_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "StormyProduct" ("Id") ON DELETE RESTRICT
);
INSERT INTO Review VALUES(1,'2019-11-28 15:38:37.3220054+00:00',0,'1d10464a-bd47-4030-b21d-52a9934ca862',5,'Cumque voluptas aut qui nesciunt qui.','I saw one of these in South Korea and I bought one.','Darrell Martins',0,5);
INSERT INTO Review VALUES(2,'2019-11-28 15:38:37.4633887+00:00',0,'2670103c-6fef-4bd5-ac1d-21dc5d7b813d',7,'Recusandae voluptates numquam consequatur doloribus ut.','The box this comes in is 3 yard by 6 light-year and weights 15 gram!!!','Thelma Silva',4,5);
INSERT INTO Review VALUES(3,'2019-11-28 15:38:37.252998+00:00',0,'3776071a-0e8a-4bd6-8fb6-fa5fc13b6d83',4,'Dolores porro distinctio nobis.','I saw one of these in New Zealand and I bought one.','Tommy Moraes',4,5);
INSERT INTO Review VALUES(4,'2019-11-28 15:38:37.5336861+00:00',0,'927332b2-24dc-41c6-a550-70cc5833ed6b',8,'Numquam tenetur minus sed quasi incidunt et qui.','heard about this on dance-rock radio, decided to give it a try.','Rogelio Albuquerque',4,5);
INSERT INTO Review VALUES(5,'2019-11-28 15:38:37.185183+00:00',0,'dd1dd750-375c-4b2b-9b56-fd9de890b3cc',3,'Corrupti id distinctio.','SoCal cockroaches are unwelcome, crafty, and tenacious. This product keeps them away.','Kristi Silva',0,5);
INSERT INTO Review VALUES(6,'2019-11-28 15:38:37.6096546+00:00',0,'5d03ad70-499f-4328-af81-4df024d7a3ab',9,'Mollitia vel qui sint similique distinctio.','talk about optimism!!!','Salvatore Xavier',5,5);
INSERT INTO Review VALUES(7,'2019-11-28 15:38:37.1169318+00:00',0,'69325532-679b-45d9-96ce-71100b12d860',2,'Vitae mollitia dolorum quia itaque aut.','It only works when I''m South Korea.','Flora Souza',3,5);
INSERT INTO Review VALUES(8,'2019-11-28 15:38:37.7017616+00:00',0,'1a64b35c-5920-42cc-9a9c-88e6a71347d9',10,'Ullam reiciendis molestias suscipit.','The box this comes in is 4 light-year by 5 inch and weights 11 megaton!!','Wesley Pereira',4,5);
INSERT INTO Review VALUES(9,'2019-11-28 15:38:37.3927473+00:00',0,'4035f1a3-e7b5-4b00-ad72-80c55a61fe15',6,'Dolores veritatis laudantium est architecto voluptas suscipit ut.','I tried to behead it but got truffle all over it.','Marty Carvalho',3,5);
INSERT INTO Review VALUES(10,'2019-11-28 15:38:36.9838213+00:00',0,'26aa9077-1f6e-4e65-9087-42ce895f59aa',1,'Nulla sed possimus eius incidunt qui nostrum in.','heard about this on original pilipino music radio, decided to give it a try.','Lydia Santos',0,5);
CREATE TABLE IF NOT EXISTS "StormyOrder" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_StormyOrder" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "OrderUniqueKey" BLOB NOT NULL,
    "StormyCustomerId" TEXT NULL,
    "PaymentId" INTEGER NOT NULL,
    "ShipmentId" INTEGER NULL,
    "PickUpInStore" INTEGER NOT NULL,
    "IsCancelled" INTEGER NOT NULL,
    "Note" TEXT NULL,
    "Comment" TEXT NULL,
    "Discount" TEXT NOT NULL,
    "TotalPrice" TEXT NOT NULL,
    "OrderDate" TEXT NOT NULL,
    "RequiredDate" TEXT NOT NULL,
    "PaymentDate" TEXT NULL,
    "Status" INTEGER NOT NULL,
    "StockId" INTEGER NULL,
    CONSTRAINT "FK_StormyOrder_Stock_StockId" FOREIGN KEY ("StockId") REFERENCES "Stock" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_StormyOrder_StormyCustomer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE RESTRICT
);
CREATE TABLE IF NOT EXISTS "Payment" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Payment" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "StormyOrderId" INTEGER NOT NULL,
    "CreatedOn" TEXT NOT NULL,
    "Amount" TEXT NOT NULL,
    "PaymentFee" TEXT NOT NULL,
    "PaymentMethod" TEXT NULL,
    "GatewayTransactionId" TEXT NULL,
    "PaymentStatus" INTEGER NOT NULL,
    "FailureMessage" TEXT NULL,
    "BoletoUrl" TEXT NULL,
    "BoletoBarcode" TEXT NULL,
    CONSTRAINT "FK_Payment_StormyOrder_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES "StormyOrder" ("Id") ON DELETE RESTRICT
);
CREATE TABLE IF NOT EXISTS "Shipment" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Shipment" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "StormyOrderId" INTEGER NOT NULL,
    "WhoReceives" TEXT NULL,
    "TrackNumber" TEXT NULL,
    "ShipmentMethod" TEXT NULL,
    "ShipmentServiceName" TEXT NULL,
    "ShipmentProvider" TEXT NULL,
    "TotalWeight" REAL NOT NULL,
    "TotalHeight" REAL NOT NULL,
    "TotalWidth" REAL NOT NULL,
    "TotalLength" REAL NOT NULL,
    "TotalArea" REAL NOT NULL,
    "CubeRoot" REAL NOT NULL,
    "SafeAmount" TEXT NOT NULL,
    "CreatedOn" TEXT NOT NULL,
    "ShippedDate" TEXT NULL,
    "DeliveryDate" TEXT NULL,
    "ExpectedDeliveryDate" TEXT NULL,
    "ExpectedHourOfDay" TEXT NULL,
    "Comment" TEXT NULL,
    "DeliveryCost" TEXT NOT NULL,
    "BillingAddressId" INTEGER NOT NULL,
    "DestinationAddressId" INTEGER NOT NULL,
    "Status" INTEGER NOT NULL,
    CONSTRAINT "FK_Shipment_CustomerAddress_BillingAddressId" FOREIGN KEY ("BillingAddressId") REFERENCES "CustomerAddress" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_Shipment_CustomerAddress_DestinationAddressId" FOREIGN KEY ("DestinationAddressId") REFERENCES "CustomerAddress" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_Shipment_StormyOrder_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES "StormyOrder" ("Id") ON DELETE RESTRICT
);
CREATE TABLE IF NOT EXISTS "OrderItem" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_OrderItem" PRIMARY KEY AUTOINCREMENT,
    "LastModified" TEXT NOT NULL,
    "IsDeleted" INTEGER NOT NULL,
    "Quantity" INTEGER NOT NULL,
    "Price" TEXT NOT NULL,
    "StormyProductId" INTEGER NOT NULL,
    "StormyOrderId" INTEGER NOT NULL,
    "ShipmentId" INTEGER NULL,
    CONSTRAINT "FK_OrderItem_Shipment_ShipmentId" FOREIGN KEY ("ShipmentId") REFERENCES "Shipment" ("Id") ON DELETE RESTRICT,
    CONSTRAINT "FK_OrderItem_StormyOrder_StormyOrderId" FOREIGN KEY ("StormyOrderId") REFERENCES "StormyOrder" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_OrderItem_StormyProduct_StormyProductId" FOREIGN KEY ("StormyProductId") REFERENCES "StormyProduct" ("Id") ON DELETE CASCADE
);
DELETE FROM sqlite_sequence;
INSERT INTO sqlite_sequence VALUES('Brand',60);
INSERT INTO sqlite_sequence VALUES('Category',60);
INSERT INTO sqlite_sequence VALUES('CustomerAddress',24);
INSERT INTO sqlite_sequence VALUES('Media',60);
INSERT INTO sqlite_sequence VALUES('VendorAddress',60);
INSERT INTO sqlite_sequence VALUES('Wishlist',12);
INSERT INTO sqlite_sequence VALUES('StormyVendor',60);
INSERT INTO sqlite_sequence VALUES('StormyProduct',60);
INSERT INTO sqlite_sequence VALUES('ProductCategory',60);
INSERT INTO sqlite_sequence VALUES('ProductMedia',60);
INSERT INTO sqlite_sequence VALUES('Review',10);
CREATE INDEX "IX_AspNetRoleClaims_RoleId" ON "AspNetRoleClaims" ("RoleId");
CREATE UNIQUE INDEX "RoleNameIndex" ON "AspNetRoles" ("NormalizedName");
CREATE INDEX "IX_AspNetUserClaims_UserId" ON "AspNetUserClaims" ("UserId");
CREATE INDEX "IX_AspNetUserLogins_UserId" ON "AspNetUserLogins" ("UserId");
CREATE INDEX "IX_AspNetUserRoles_RoleId" ON "AspNetUserRoles" ("RoleId");
CREATE INDEX "EmailIndex" ON "AspNetUsers" ("NormalizedEmail");
CREATE UNIQUE INDEX "UserNameIndex" ON "AspNetUsers" ("NormalizedUserName");
CREATE INDEX "IX_Comment_ProductId" ON "Comment" ("ProductId");
CREATE INDEX "IX_Comment_StormyCustomerId" ON "Comment" ("StormyCustomerId");
CREATE INDEX "IX_CustomerAddress_OwnerId" ON "CustomerAddress" ("OwnerId");
CREATE INDEX "IX_Entity_EntityTypeId" ON "Entity" ("EntityTypeId");
CREATE INDEX "IX_OrderItem_ShipmentId" ON "OrderItem" ("ShipmentId");
CREATE INDEX "IX_OrderItem_StormyOrderId" ON "OrderItem" ("StormyOrderId");
CREATE INDEX "IX_OrderItem_StormyProductId" ON "OrderItem" ("StormyProductId");
CREATE UNIQUE INDEX "IX_Payment_StormyOrderId" ON "Payment" ("StormyOrderId");
CREATE INDEX "IX_ProductAttribute_GroupId" ON "ProductAttribute" ("GroupId");
CREATE INDEX "IX_ProductAttributeValue_AttributeId" ON "ProductAttributeValue" ("AttributeId");
CREATE INDEX "IX_ProductAttributeValue_ProductId" ON "ProductAttributeValue" ("ProductId");
CREATE INDEX "IX_ProductCategory_CategoryId" ON "ProductCategory" ("CategoryId");
CREATE INDEX "IX_ProductCategory_ProductId" ON "ProductCategory" ("ProductId");
CREATE INDEX "IX_ProductLink_LinkedProductId" ON "ProductLink" ("LinkedProductId");
CREATE INDEX "IX_ProductLink_ProductId" ON "ProductLink" ("ProductId");
CREATE INDEX "IX_ProductMedia_MediaId" ON "ProductMedia" ("MediaId");
CREATE INDEX "IX_ProductMedia_StormyProductId" ON "ProductMedia" ("StormyProductId");
CREATE INDEX "IX_ProductOptionCombination_OptionId" ON "ProductOptionCombination" ("OptionId");
CREATE INDEX "IX_ProductOptionCombination_ProductId" ON "ProductOptionCombination" ("ProductId");
CREATE INDEX "IX_ProductOptionValue_OptionId" ON "ProductOptionValue" ("OptionId");
CREATE INDEX "IX_ProductOptionValue_ProductId" ON "ProductOptionValue" ("ProductId");
CREATE INDEX "IX_ProductTemplate_StormyProductId" ON "ProductTemplate" ("StormyProductId");
CREATE INDEX "IX_ProductTemplateProductAttribute_ProductAttributeId" ON "ProductTemplateProductAttribute" ("ProductAttributeId");
CREATE INDEX "IX_Review_StormyCustomerId" ON "Review" ("StormyCustomerId");
CREATE INDEX "IX_Review_StormyProductId" ON "Review" ("StormyProductId");
CREATE UNIQUE INDEX "IX_Shipment_BillingAddressId" ON "Shipment" ("BillingAddressId");
CREATE UNIQUE INDEX "IX_Shipment_DestinationAddressId" ON "Shipment" ("DestinationAddressId");
CREATE UNIQUE INDEX "IX_Shipment_StormyOrderId" ON "Shipment" ("StormyOrderId");
CREATE UNIQUE INDEX "IX_StormyCustomer_CustomerWishlistId" ON "StormyCustomer" ("CustomerWishlistId");
CREATE INDEX "IX_StormyCustomer_CustomerWishlistId1" ON "StormyCustomer" ("CustomerWishlistId1");
CREATE INDEX "IX_StormyCustomer_DefaultBillingAddressId" ON "StormyCustomer" ("DefaultBillingAddressId");
CREATE INDEX "IX_StormyCustomer_DefaultShippingAddressId" ON "StormyCustomer" ("DefaultShippingAddressId");
CREATE INDEX "IX_StormyCustomer_RoleId" ON "StormyCustomer" ("RoleId");
CREATE INDEX "IX_StormyOrder_StockId" ON "StormyOrder" ("StockId");
CREATE INDEX "IX_StormyOrder_StormyCustomerId" ON "StormyOrder" ("StormyCustomerId");
CREATE INDEX "IX_StormyProduct_BrandId" ON "StormyProduct" ("BrandId");
CREATE INDEX "IX_StormyProduct_StockId" ON "StormyProduct" ("StockId");
CREATE INDEX "IX_StormyProduct_VendorId" ON "StormyProduct" ("VendorId");
CREATE UNIQUE INDEX "IX_StormyVendor_VendorAddressId" ON "StormyVendor" ("VendorAddressId");
CREATE INDEX "IX_WishlistItem_ProductId" ON "WishlistItem" ("ProductId");
CREATE INDEX "IX_WishlistItem_WishlistId" ON "WishlistItem" ("WishlistId");
CREATE INDEX "IX_WishlistItem_WishlistId1" ON "WishlistItem" ("WishlistId1");
COMMIT;
