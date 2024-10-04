INSERT INTO public."Categories" ("Name", "Description", "Thumbnail")
VALUES
('Electronics', 'Devices and gadgets', 'https://cdn-icons-png.flaticon.com/512/3659/3659899.png'),
('Books', 'Various genres of books', 'https://cdn-icons-png.flaticon.com/512/330/330731.png'),
('Clothing', 'Apparel and accessories', 'https://cdn-icons-png.flaticon.com/512/4658/4658953.png'),
('Furniture', 'Home and office furniture', 'https://cdn-icons-png.flaticon.com/512/196/196260.png'),
('Toys', 'Toys and games for children', 'https://cdn-icons-png.flaticon.com/512/1807/1807601.png'),
('Groceries', 'Daily essentials and food items', 'https://cdn-icons-png.freepik.com/512/2884/2884593.png'),
('Sports', 'Sports equipment and apparel', 'https://cdn-icons-png.freepik.com/512/5351/5351365.png'),
('Beauty', 'Beauty and personal care products', 'https://cdn-icons-png.flaticon.com/512/3501/3501241.png');

INSERT INTO public."Products" ("Sku", "Name", "Price", "Weight", "Description", "Thumbnail", "Image", "CreationDate", "Stock", "CategoryId")
VALUES
('ELEC-SMRT-001', 'Smartphone', 699.99, 0.5, 'Latest model smartphone with advanced features', 'https://cdn.thewirecutter.com/wp-content/media/2024/05/smartphone-2048px-1013.jpg', 'https://cdn.thewirecutter.com/wp-content/media/2024/05/smartphone-2048px-1013.jpg', '2024-10-03', 50, 1),
('ELEC-LPTP-002', 'Laptop', 1299.99, 2.5, 'High-performance laptop for professionals', 'https://cdn.mos.cms.futurecdn.net/Ajc3ezCTN4FGz2vF4LpQn9-1200-80.jpg', 'https://cdn.mos.cms.futurecdn.net/Ajc3ezCTN4FGz2vF4LpQn9-1200-80.jpg', '2024-10-03', 30, 1),
('ELEC-HDPH-003', 'Headphones', 199.99, 0.3, 'Noise-cancelling over-ear headphones', 'https://www.energysistem.com/cdnassets/products/45305/principal_2000.jpg', 'https://www.energysistem.com/cdnassets/products/45305/principal_2000.jpg', '2024-10-03', 100, 1),
('FURN-BKSH-001', 'Bookshelf', 89.99, 15.0, 'Wooden bookshelf with multiple compartments', 'https://www.ubuy.com.eg/productimg/?image=aHR0cHM6Ly9tLm1lZGlhLWFtYXpvbi5jb20vaW1hZ2VzL0kvNzFTZVhQYll0VUwuX0FDX1NMMTUwMF8uanBn.jpg', 'https://www.ubuy.com.eg/productimg/?image=aHR0cHM6Ly9tLm1lZGlhLWFtYXpvbi5jb20vaW1hZ2VzL0kvNzFTZVhQYll0VUwuX0FDX1NMMTUwMF8uanBn.jpg','2024-10-03', 20, 2),
('CLOT-RNSH-001', 'Running Shoes', 59.99, 0.8, 'Comfortable running shoes for all terrains', 'https://cdn.thewirecutter.com/wp-content/media/2023/09/running-shoes-2048px-5960.jpg', 'https://cdn.thewirecutter.com/wp-content/media/2023/09/running-shoes-2048px-5960.jpg', '2024-10-03', 75, 3),
('ELEC-TBLT-004', 'Tablet', 499.99, 0.8, 'High-resolution tablet with long battery life', 'https://cdn.thewirecutter.com/wp-content/media/2024/06/besttablets-2048px-9875.jpg', 'https://cdn.thewirecutter.com/wp-content/media/2024/06/besttablets-2048px-9875.jpg', '2024-10-03', 40, 1),
('ELEC-CMRA-005', 'Digital Camera', 899.99, 1.2, 'Professional digital camera with 4K video recording', 'https://i.pcmag.com/imagery/roundups/018cwxjHcVMwiaDIpTnZJ8H-22..v1570842461.jpg', 'https://i.pcmag.com/imagery/roundups/018cwxjHcVMwiaDIpTnZJ8H-22..v1570842461.jpg', '2024-10-03', 25, 1),
('FURN-CHRS-002', 'Office Chair', 149.99, 10.0, 'Ergonomic office chair with lumbar support', 'https://cellbell.in/cdn/shop/files/038_4.png?v=1715064457', 'https://cellbell.in/cdn/shop/files/038_4.png?v=1715064457', '2024-10-03', 15, 2),
('CLOT-JCKT-002', 'Winter Jacket', 129.99, 1.5, 'Warm and waterproof winter jacket', 'https://n.nordstrommedia.com/it/8fedc044-51e3-40e5-ab2c-0c91bdd1207d.jpeg?h=600&w=750', 'https://n.nordstrommedia.com/it/8fedc044-51e3-40e5-ab2c-0c91bdd1207d.jpeg?h=600&w=750', '2024-10-03', 60, 3),
('TOYS-LEGO-001', 'LEGO Set', 59.99, 2.0, 'Creative LEGO building set for kids', 'https://www.lego.com/cdn/cs/set/assets/blt776c5237d6f20cf2/APEX_article_Card_Content.jpg?format=jpg&quality=80&width=700&dpr=1?fit=crop&quality=80&width=700&dpr=1', 'https://www.lego.com/cdn/cs/set/assets/blt776c5237d6f20cf2/APEX_article_Card_Content.jpg?format=jpg&quality=80&width=700&dpr=1?fit=crop&quality=80&width=700&dpr=1', '2024-10-03', 80, 4),
('SPRT-BALL-001', 'Soccer Ball', 29.99, 0.4, 'Professional-grade soccer ball', 'https://nwscdn.com/media/catalog/product/cache/all/thumbnail/800x/0dc2d03fe217f8c83829496872af24a0/t/r/training-football-in-orange.jpg', 'https://nwscdn.com/media/catalog/product/cache/all/thumbnail/800x/0dc2d03fe217f8c83829496872af24a0/t/r/training-football-in-orange.jpg', '2024-10-03', 100, 5),
('BEAU-SHMP-001', 'Shampoo', 9.99, 0.5, 'Organic shampoo for all hair types', 'https://www.babyforest.in/cdn/shop/products/IMG_1631final.jpg?v=1661261938', 'https://www.babyforest.in/cdn/shop/products/IMG_1631final.jpg?v=1661261938', '2024-10-03', 200, 6),
('GRCR-PAST-001', 'Pasta', 2.99, 1.0, 'Italian pasta made from durum wheat', 'https://skinnyspatula.com/wp-content/uploads/2022/01/Pink_Pasta_Sauce1.jpg', 'https://skinnyspatula.com/wp-content/uploads/2022/01/Pink_Pasta_Sauce1.jpg', '2024-10-03', 150, 7);

INSERT INTO public."Customers" ("Email", "Password", "FullName", "BillingAddress", "DefaultShippingAddress", "Country", "Phone")
VALUES
('john.doe@example.com', 'password123', 'John Doe', '123 Main St, Springfield', '123 Main St, Springfield', 'USA', '555-1234'),
('jane.smith@example.com', 'securepass', 'Jane Smith', '456 Elm St, Metropolis', '456 Elm St, Metropolis', 'USA', '555-5678'),
('michael.jones@example.com', 'mypassword', 'Michael Jones', '789 Oak St, Gotham', '789 Oak St, Gotham', 'USA', '555-8765'),
('emily.davis@example.com', 'emilypass', 'Emily Davis', '101 Pine St, Star City', '101 Pine St, Star City', 'USA', '555-4321'),
('william.brown@example.com', 'williampass', 'William Brown', '202 Maple St, Central City', '202 Maple St, Central City', 'USA', '555-6789');

INSERT INTO public."Orders" ("Amount", "ShippingAddress", "OrderAddress", "OrderEmail", "OrderDate", "OrderStatus", "CustomerId")
VALUES
(150.75, '123 Main St, Springfield', '123 Main St, Springfield', 'john.doe@example.com', '2024-10-01', 'Shipped', 1),
(299.99, '456 Elm St, Metropolis', '456 Elm St, Metropolis', 'jane.smith@example.com', '2024-10-02', 'Processing', 2),
(89.50, '789 Oak St, Gotham', '789 Oak St, Gotham', 'michael.jones@example.com', '2024-10-03', 'Delivered', 3),
(45.00, '101 Pine St, Star City', '101 Pine St, Star City', 'emily.davis@example.com', '2024-10-04', 'Pending', 4),
(120.00, '202 Maple St, Central City', '202 Maple St, Central City', 'william.brown@example.com', '2024-10-05', 'Cancelled', 5);

INSERT INTO public."OrderDetails" ("OrderId", "ProductId", "Price", "Sku", "Quantity")
VALUES
(1, 1, 699.99, 'ELEC-SMRT-001', 1),
(2, 2, 1299.99, 'ELEC-LPTP-002', 1),
(3, 3, 199.99, 'ELEC-HDPH-003', 2),
(4, 4, 89.99, 'FURN-BKSH-001', 1),
(5, 5, 59.99, 'CLOT-RNSH-001', 3),
(1, 6, 499.99, 'ELEC-TBLT-004', 1),
(2, 7, 899.99, 'ELEC-CMRA-005', 1),
(3, 8, 149.99, 'FURN-CHRS-002', 1),
(4, 9, 129.99, 'CLOT-JCKT-002', 2),
(5, 10, 59.99, 'TOYS-LEGO-001', 1);
