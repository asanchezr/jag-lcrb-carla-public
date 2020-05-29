﻿Feature: E2E_CRSApplication_Licence_privatecorp_store_relocation
    As a logged in business user
    I want to submit a CRS Application for a private corporation
    And request a store relocation for the approved application

Scenario: Start Application
    Given I am logged in to the dashboard as a private corporation
    And the account is deleted
    And I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile
    And I review the organization structure
    And I submit the organization structure
    And I complete the Cannabis Retail Store application
    And I click on the Pay for Application button
    And I enter the payment information
    And I return to the dashboard
    And the application is approved
    And I click on the Licences tab for a Cannabis Retail Store
    And I pay the licensing fee
    And I request a store relocation
    And the account is deleted
    Then I see the login page