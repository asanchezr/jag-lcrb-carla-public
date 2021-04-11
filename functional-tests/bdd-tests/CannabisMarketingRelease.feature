﻿Feature: CannabisMarketingRelease
    As a logged in business user
    I want to run a release test for a Cannabis Marketing Licence

@cannabismktg @release6
Scenario: Cannabis Marketing Release (Private Corporation)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Cannabis Marketing Licence
    And I review the account profile for a private corporation
    And I complete the Cannabis Marketing application for a private corporation
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a Cannabis Marketing Licence
    And I click on the link for Dashboard
    And the application is approved
    And I click on the link for Licences & Authorizations
    And I click on the link for Download Licence
    And I confirm the terms and conditions for a Cannabis marketing licence
    And the account is deleted
    Then I see the login page

@cannabismktg
Scenario: Cannabis Marketing Release (Sole Proprietorship)
    Given I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for a Cannabis Marketing Licence
    And I review the account profile for a sole proprietorship
    And I complete the Cannabis Marketing application for a sole proprietorship
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a Cannabis Marketing Licence
    And I click on the link for Dashboard
    And the application is approved
    And I click on the link for Licences & Authorizations
    And I click on the link for Download Licence
    And I confirm the terms and conditions for a Cannabis marketing licence
    And the account is deleted
    Then I see the login page