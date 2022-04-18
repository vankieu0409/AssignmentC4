use AssignmentC4
go

insert into CUSTOMER (IdCustomer,CustomerName,Sex,Account,Password,NumberPhone,IsAdmin,IsDeleted)
values('889ade50-633a-447d-8d0a-873b07eab4e2', N'Kiều',1,N'bau_csnv',N'kaka',N'0409199844',1,1),
('12a6f84c-76ff-44d7-9e80-1655594ec57a', N'Trang',0,N'trang_pt',N'kaka',N'0409199844',1,1),
('3c1548a1-2bff-4d0b-8d2a-167f2098755f', N'Lưu',1,N'luubiker',N'kaka',N'0409199844',1,1)



insert into PRODUCT (IdProduct,NameProduct,Price,ImportPrice, Image,IsDeleted,Quantity)
values('93583ff3-60da-4ead-b1b2-68cb369c5325',N'Iphone 13',1000,500,N'https://www.google.com/aclk?sa=l&ai=DChcSEwjf8_nQ-Jv3AhVBqpYKHUkZDwAYABAFGgJ0bA&sig=AOD64_3pgO89EnnYwFbSaxtK1doyRCs5rw&adurl&ctype=5&ved=2ahUKEwia2O_Q-Jv3AhXKEKYKHUI5COsQvhd6BAgBEFM',1,50),
('5245b2b2-4aa6-4aad-bd60-fe0a791f7b09',N'Iphone 13',1000,500,N'https://www.google.com/aclk?sa=l&ai=DChcSEwjf8_nQ-Jv3AhVBqpYKHUkZDwAYABALGgJ0bA&sig=AOD64_2u3uPwJkAQGGqQZJ2WbITGgWSFKg&adurl&ctype=5&ved=2ahUKEwia2O_Q-Jv3AhXKEKYKHUI5COsQvhd6BAgBEGg',1,50),
('5a24c5fe-b5bd-4f3c-b667-d8b6a16f3310',N'gà',1000, 500,N'https://www.google.com/imgres?imgurl=https%3A%2F%2Fimage.thanhnien.vn%2Fw1024%2FUploaded%2F2022%2Fayhunaa%2F2022_01_05%2Fga1-672.jpg&imgrefurl=https%3A%2F%2Fthanhnien.vn%2Fchu-ga-ky-la-cua-8x-mien-tay-than-hinh-trui-long-thich-ngoi-choi-tren-mam-post1418359.html&tbnid=F9TXmsK--LD7QM&vet=12ahUKEwiSmePs-Jv3AhWfzosBHQHFDqoQMygBegUIARC8AQ..i&docid=_OkUH4zwqk7PSM&w=5472&h=3648&q=g%C3%A0&ved=2ahUKEwiSmePs-Jv3AhWfzosBHQHFDqoQMygBegUIARC8AQ',1,50),
('0e961122-8a14-4802-a85a-628b876a7c54',N'chó',1000, 500,N'https://www.google.com/imgres?imgurl=https%3A%2F%2Fhuanluyencho119.vn%2Fwp-content%2Fuploads%2F2020%2F09%2Fcach-huan-luyen-cho-phat-mot-chu-cho-khi-lam-sai-lieu-co-hieu-qua-nhu-mong-doi.jpg&imgrefurl=https%3A%2F%2Fhuanluyencho119.vn%2Fcach-huan-luyen-cho-phat-mot-chu-cho-khi-lam-sai-lieu-co-hieu-qua-nhu-mong-doi%2F&tbnid=XU3bT1mwUvSMRM&vet=12ahUKEwiD0-T4-Jv3AhUGEJQKHUZ5A2oQMygEegUIARC9AQ..i&docid=p6to-ydNip9jgM&w=1000&h=1345&q=ch%C3%B3&ved=2ahUKEwiD0-T4-Jv3AhUGEJQKHUZ5A2oQMygEegUIARC9AQ',1,50),
('b7222ee6-ec96-4845-bc8e-cca96971b2fb',N'mèo',1000, 500,N'https://tophinhanh.com/wp-content/uploads/2021/12/anh-meo-cute-hinh-meo-de-thuong-nhat-1-540x375.jpg',1,50),
('21740839-909f-414f-b139-41d9d65b78a8',N'cà phê',1000, 500,N'https://nld.mediacdn.vn/2020/5/12/23723766-0-image-a-181579697765141-15892455662811158088874.jpg',1,50),
('e64460d5-ffb1-4ac2-8da1-64df92be89a4',N'vợt muỗi',1000, 500,N'https://cdn.tgdd.vn/Files/2017/02/28/955635/chon-mua-vot-bat-muoi-tot-dung-ben-202110121330083427.jpeg',1,50),
('ea66adf4-ad73-40c8-a3a2-0906f5ec5a8b',N'Loa',1000, 500,N'https://images.fpt.shop/unsafe/filters:quality(90)/fptshop.com.vn/uploads/images/tin-tuc/120833/Originals/637034463426838545_hk_onyx_studio_5_lava_black_hero_008_x2-1605x1605px.jpg',1,50),
('d413638f-e938-466a-a729-3eac2f2cef08',N'Sạc',1000, 500,N'https://www.phukiensamsung.com/Uploads/bo-sac-galaxy-j2-prime-chinh-hang-17062411465157810.jpg',1,50),
('564c96fe-e595-4ea6-80b2-21331e0834e1',N'Bông tăm',1000, 500,N'https://cdn.tgdd.vn/Products/Images/3727/217303/bhx/bong-tam-1-lop-unibee-65g-202001101517574192.JPG',1,50),
('c8e9b1fd-4251-41ef-a009-451c552e6d52',N'Laptop',1000, 500,N'https://cdn.tgdd.vn/Products/Images/44/238131/lg-gram-14-i7-14z90pgah75a5-0-600x600.jpg',1,50),
('e979172c-e49f-4c80-bcc0-b933b7d279b9',N'bò Húc',1000, 500,N'https://cdn.tgdd.vn/Products/Images/3226/83742/bhx/6-lon-nuoc-tang-luc-redbull-250ml-202103272201250743.jpg',1,50),
('6d8ede0d-47aa-49cd-95dc-16b114da67bf',N'Monter',1000, 500,N'https://cf.shopee.vn/file/2526127c6c4d41fe986408fd2fecdab5_tn',1,50),
('dd7308ff-1b79-44a4-a13b-99e1780a3aef',N'Đèn',1000, 500,N'https://givasolar.com/wp-content/uploads/2018/10/day-den-led-sieu-sang-gv-ucsl.jpg',1,50),
('fb64d8c4-a83f-489b-a1dd-88f1e25d9bc6',N'bảng',1000, 500,N'https://bangvietnam.net/image/bang-viet-phan-xanh-cc.jpg',1,50),
('c7e70082-00ce-4b16-84de-b148c604abcd',N'Bàn',1000, 500,N'https://noithattoz.com/wp-content/uploads/2020/06/ban-chan-sat-1m2-BCK84-sp.jpg',1,50)

select*from CUSTOMER

insert into CARTS(CustomerID,CartId,TotalCost,CartStatus,IsDeleted)
values('12A6F84C-76FF-44D7-9E80-1655594EC57A','ab8ed406-4b5f-4f70-9b1c-00b867f41176',1000,0,1),
('3C1548A1-2BFF-4D0B-8D2A-167F2098755F','a881a60d-c1d4-449d-ae50-c2d2b08d4f71',1000,0,1),
('889ADE50-633A-447D-8D0A-873B07EAB4E2','59778c0b-1853-4beb-b564-892af4c58936',1000,1,1)

insert into PRODUCT_CARTS(IdProduct,IdCart,Quantity,Price,IsDeleted)
values( '564c96fe-e595-4ea6-80b2-21331e0834e1','ab8ed406-4b5f-4f70-9b1c-00b867f41176',2,2000,1),
( 'dd7308ff-1b79-44a4-a13b-99e1780a3aef','ab8ed406-4b5f-4f70-9b1c-00b867f41176',2,2000,1),
( 'c7e70082-00ce-4b16-84de-b148c604abcd','ab8ed406-4b5f-4f70-9b1c-00b867f41176',2,2000,1),
( 'b7222ee6-ec96-4845-bc8e-cca96971b2fb','a881a60d-c1d4-449d-ae50-c2d2b08d4f71',2,2000,1)