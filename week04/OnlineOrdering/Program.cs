using System;

class Program
{
    static void Main(string[] args)
    {
        // Instances Created: See Resources at the bottom of this program.

        // Product
        Product product1 = new Product("Logitech USB Computer Headset H390", "981-000014", 24.99, 1);
        Product product2 = new Product("Lenovo ThinkPad E16 G2", "21MA003NSC", 1279, 1);
        Product product3 = new Product("Samsung Galaxy S25", "SM-S251", 859.99, 1);

        // Address
        Address address1 = new Address("3400 Ashton Blvd Ste 220", "Lehi", "Utah", "USA");
        Address address2 = new Address("4933 Simons Hollow Road", "Lawrenceville", "Pennsylvania", "USA");
        Address address3 = new Address("3309 rue Saint-Antoine", "Rromont", "Quebec", "CANADA");

        // Customer
        Customer customer1 = new Customer("Ingrid Mayorga", address1);
        Customer customer2 = new Customer("Dylan Encarnacion", address2);
        Customer custoemr3 = new Customer("Ian Encarnacion", address3);

        // Create orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        Order order3 = new Order(custoemr3);

    }
}

// Product information was taken from the following resources:
// https://www.amazon.com/-/es/Tel%C3%A9fono-tel%C3%A9fono-inteligente-desbloqueado-procesador/dp/B0DSR15XZT/ref=sr_1_1?_encoding=UTF8&content-id=amzn1.sym.69a935ef-cee6-41d5-aefa-c36bfc7821bc&dib=eyJ2IjoiMSJ9._BK2wtrnjlkaczBGPlGlFF5Pl4-C_Dfx4uViZlvqrt5iO2oHiQtNa7wB6IKrRHf4nqrw6HLhyko6NwJ20jx_MNDCTQm5XcixnvoSy4vTfmd8CbDJNJIu5ecj6pPcUfyHJRC-w_B5EgsJ-ZK5l5KISRH-vRye9Ko0yZB0XU9VeSP6Ref9CIMSmbcKD09m03xFub-E6aW8MvU7PMoDSZVEKdjfr5hq3W-yP12YsBld8fk.peVqYzqIGqr5qAO7p8YhEnnuWwBZxYrVGzrogzdY8jM&dib_tag=se&keywords=smartphones&pd_rd_r=67d62630-24a2-4013-b839-3981101b79de&pd_rd_w=DXwVK&pd_rd_wg=WSyCK&qid=1739052580&sr=8-1&th=1
// https://psref.lenovo.com/Detail/ThinkPad_E16_Gen_2_Intel?M=21MA003NSC&form=MG0AV3
// https://www.logitech.com/en-us/products/headsets/h390-usb-headset.981-001285.html?form=MG0AV3

// Address information
// https://www.bestrandoms.com/random-address-in-ca?quantity=6

// Customer Names
// These are my family names :)