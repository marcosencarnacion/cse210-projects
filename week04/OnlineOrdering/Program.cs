using System;

class Program
{
    static void Main(string[] args)
    {
        // Instances Created: See Resources at the bottom of this program.

        // Products
        Product product1 = new Product("Logitech USB Computer Headset H390", "981-000014", 24.99, 1);
        Product product2 = new Product("Lenovo ThinkPad E16 G2", "21MA003NSC", 1279, 1);
        Product product3 = new Product("Samsung Galaxy S25", "SM-S251", 859.99, 1);
        Product product4 = new Product("Motorola Moto G Stylus 5G", "XT2131", 148.49, 1);
        Product product5 = new Product("Apple iPad Pro (M4)", "A2837", 1199, 1);
        Product product6 = new Product("YSSOA Gaming Chair", "FNCHARGAME01BRFRV15", 124, 1);

        // Add 

        // Addresses
        Address address1 = new Address("3400 Ashton Blvd Ste 220", "Lehi", "Utah", "USA");
        Address address2 = new Address("4933 Simons Hollow Road", "Lawrenceville", "Pennsylvania", "USA");
        Address address3 = new Address("3309 rue Saint-Antoine", "Rromont", "Quebec", "CANADA");

        // Customers
        Customer customer1 = new Customer("Ingrid Mayorga", address1);
        Customer customer2 = new Customer("Dylan Encarnacion", address2);
        Customer customer3 = new Customer("Ian Encarnacion", address3);

        // Create orders and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product6);
        order2.AddProduct(product1);

        Order order3 = new Order(customer3);
        order3.AddProduct(product2);
        order3.AddProduct(product5);
        order3.AddProduct(product6);

        // Show order details for Order No. 1
        Console.WriteLine("--- Order No. 1 ---");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}");
        Console.WriteLine();



    }
}

// Product information was taken from the following resources:
// https://www.amazon.com/-/es/Tel%C3%A9fono-tel%C3%A9fono-inteligente-desbloqueado-procesador/dp/B0DSR15XZT/ref=sr_1_1?_encoding=UTF8&content-id=amzn1.sym.69a935ef-cee6-41d5-aefa-c36bfc7821bc&dib=eyJ2IjoiMSJ9._BK2wtrnjlkaczBGPlGlFF5Pl4-C_Dfx4uViZlvqrt5iO2oHiQtNa7wB6IKrRHf4nqrw6HLhyko6NwJ20jx_MNDCTQm5XcixnvoSy4vTfmd8CbDJNJIu5ecj6pPcUfyHJRC-w_B5EgsJ-ZK5l5KISRH-vRye9Ko0yZB0XU9VeSP6Ref9CIMSmbcKD09m03xFub-E6aW8MvU7PMoDSZVEKdjfr5hq3W-yP12YsBld8fk.peVqYzqIGqr5qAO7p8YhEnnuWwBZxYrVGzrogzdY8jM&dib_tag=se&keywords=smartphones&pd_rd_r=67d62630-24a2-4013-b839-3981101b79de&pd_rd_w=DXwVK&pd_rd_wg=WSyCK&qid=1739052580&sr=8-1&th=1
// https://psref.lenovo.com/Detail/ThinkPad_E16_Gen_2_Intel?M=21MA003NSC&form=MG0AV3
// https://www.logitech.com/en-us/products/headsets/h390-usb-headset.981-001285.html?form=MG0AV3
// https://www.amazon.com/-/es/Motorola-Stylus-Desbloqueado-C%C3%A1mara-c%C3%B3smico/dp/B0C2S6TKTL/ref=sr_1_3?crid=2ZWYG07KW7M06&dib=eyJ2IjoiMSJ9.eA3zYahb9D4RGb9tgHKQneSOUDikiVIX7owxQhHAdElZgN9JSDiZavyZUNYSU7fTfMIaCrka5ZvyogWGQLRxgZ7WTIYUkBB-WknDkiHnNG3wrX2H6FJDS8hROOHeaMkcHDC6cQAsOq4IIkmV_xue6weqt9aNrpL1Zia7_OwG0mzVh7bsFmoN997r0ZUR5wsFpsu90KWd7j0NQNBbSAohWD6XG_EhHiFdkgieb-BHAMo.Zk-XshRfYJ5kAGg_JOdMuz8dVl-XKwSW8M9roilcIZY&dib_tag=se&keywords=motorola%2Bg%2Bstylus%2B5g%2B2024&qid=1739054054&sprefix=Motorolla%2BG%2BStyl%2Caps%2C153&sr=8-3&th=1
// https://www.amazon.com/-/es/Apple-iPad-Pro-M4-Intelligence/dp/B0DS44QVYY/ref=sr_1_3?crid=2TIBK640FGTSN&dib=eyJ2IjoiMSJ9.gUJWLSIO2P5QQdc_BzM1OCEjaE_XhvToNMOtM9pg4_VTA-kbAjcsrjwOExrjFezbCFbEjRolLdE5LmbznVa-rMX0yocSkPD6W_lnJfk9yrE0do_joyriGBnpCa00qTmwVbTDWztQKH7ZQ0XWUV1CMdHmlQpXJ1Uf-DysknsyBYk-i0hLt9dM_hWNPf0dOXlvra8Ndjnz2HwxgvL0wlyME7yjvy8cFBVBQiAD3sN6QqI._sd5Kg0T1Ua7wPZ2eaXyTaqOgk30zOJg0kzuDp_pxDE&dib_tag=se&keywords=apple%2Bipad%2Bpro%2Bm4%2B11%2Binch&qid=1739054467&sprefix=Apple%2BiPad%2BPro%2B(M4)%2Caps%2C425&sr=8-3&th=1
// https://www.amazon.com/YSSOA-Computer-Footrest-Adjustable-Ergonomic/dp/B0D4Z6QFLP/ref=sr_1_9?crid=DJFGMYJ1PPNS&dib=eyJ2IjoiMSJ9.d8dksvkzO23AHxsvuMrPf2fgyOr8amvwnjkBfgKqNL6hrqZIY0NpAusFvX5jYX_ZHYImnKkBfczq6Od3fjkl1HPpQxhMqRfe26hFVX6xFR50MTMZvs9RF14BFTBJzbYfTcECe8rbAO08GEewdhxgIoSbg599kDBf0yAwdztAQvSm6Cs7ODqoN6iq5cPwtAVA_cbmmUVyEYLmTkfp9HoxLRsv4najgbsW2appjpBr1-lc8OQt2sEPCSxxSMJtXMfnnMfIWOwHNtmvaB3WuruOuy86Wnm631VB4vSLQjPnD3WEp179OlKNIpU5epUbOemRRKA-DG_neazFgXZyMw_bFAchTIb2Jzr8HzkJyJjcB7VXmgB9sISuVY1bfCgYuN0DVa3bSpgSxj1pdrTy_x9sGDUBn-L2qEyX-CaDezFMqCJfzxtIqFZchUILUb9U3i3v.hG0yHx7AlQ5OfJWe7aGVn6h61pgviA_Qvi5CaoDRO-w&dib_tag=se&keywords=gamer%2Bchair&qid=1739054274&sprefix=%2Caps%2C129&sr=8-9&th=1

// Address information
// https://www.bestrandoms.com/random-address-in-ca?quantity=6

// Customer Names
// These are my family names :)