# DEMO-cardswipe-events
This application will read the data from USB magnetic card reader using jquery.

# What It Does
This jQuery plugin is intended for use with a magnetic card reader that simulates a keyboard. It allows a web application to interface with the reader so that scanning a card will trigger a callback function which can then act on the scanned data. Scanning a card will not result in keyboard events getting through to the underlying page, so you can scan a card without regard to which control on the page has focus.

Note that while this plugin can scan a credit card or debit card account number, it does not validate or verify that data in any way (except for the standard Luhn checksum on account numbers). The plugin simply reads the data on the card. What you do with it is up to you.

The intended use for this plugin is NOT payment processing. The Payment Card Industry (PCI) rules on handling card data are very strict, and getting stricter by the day. It is very unlikely that a payment card application built with this plugin will meet the security requirements imposed by the industry.

While there are built-in parsers to handle common credit cards, they're for convenience in testing, because those cards are so common, and the formats are well-known. The use for this plugin is with private-use cards, like company or institutional ID cards, in a low-risk application like attendance taking, or room reservation. You will need to create your own parser function for your cards.

# Getting Started
Before you try the plugin, make sure your card reader does what the plugin expects. Connect your reader, and open notepad or vi or some other plain-text editor, and then scan a card. If the scanned data does not start with a % character followed by a letter, or with a ; character followed by a number, this plugin will not be able to work with your cards and reader. However, if the % character and a letter are present, but there is a consistent prefix ahead of it, you may be able to use the plugin by configuring the prefixCharacter property. See an example below.

To use the plugin, include either dist\jquery.cardswipe.js or dist\jquery.cardswipe.min.js on your web page, after including jQuery version 1.7.2 or later.

If you are scanning credit cards like Visa, MasterCard, or American Express, there are built-in parsers within the plugin that can recognize those formats. A built-in generic parser will parse up to three lines of data. To scan private-use cards, like company or institutional ID cards, you'll need to create your own parser function, as described below.

# How to test
Run this project using visual studio. once home page is loaded, you can swipe the card, either data will filled up if card type matches with the payment card or notification will come up with correct data in case of generic card type.

