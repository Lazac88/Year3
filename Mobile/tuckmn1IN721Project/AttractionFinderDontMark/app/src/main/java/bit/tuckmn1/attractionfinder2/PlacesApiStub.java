package bit.tuckmn1.attractionfinder2;

/**
 * Created by mattt on 30/05/2017.
 * This class returns an example JSON string
 */

public class PlacesApiStub
{
    public String JSONString;

    public PlacesApiStub()
    {
        JSONString = CreateJSONString();
    }

    public String GetJSONString()
    {
        return JSONString;
    }

    public String CreateJSONString()
    {
        return "{\n" +
                "   \"html_attributions\" : [],\n" +
                "   \"next_page_token\" : \"CpQCAgEAACZ0Crz_bEuY49U9MGV_cyP-gQ_g_RWil0qKL4hFlcjMuSFModQzFNba4eN5Lj1fuHZ0XkuNSZu7B_JuKKX33NZhvPyRoknSiHQQP5nuf0tt3C9eyW-9CITCUqV5eEOK9PbKMooaZ22p9BDYIzS_E0wN3GtYi-4WLcWDNJ46DX3kUjDo73dYRpGNeGV5z7OzKvhrT9yqSt57iYjoF5KdGNOklM_Tu1Vy45EW6oqCsHWkDBrJIhR3pIgyPt3Imv4guxSJ2p6Rqf5k9Em4_751k064k2GJeQwXHY37e8oOTO0cIS7bBayS2Mhm4xo0CDEy_XxzdaGwKfFTP8eA9v2K05toOKSjY0ERxC8njiGx2UGXEhBQcUAQtv38Ge4h4BCPToF5GhRf1U0nbbddz1Fnknm2Ogs8V-oK2A\",\n" +
                "   \"results\" : [\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.87876050000001,\n" +
                "               \"lng\" : 170.5027976\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.811635,\n" +
                "                  \"lng\" : 170.6836916\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.9337525,\n" +
                "                  \"lng\" : 170.370546\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/geocode-71.png\",\n" +
                "         \"id\" : \"eb320178df8cf5d959883587a99d6e9f76a63af1\",\n" +
                "         \"name\" : \"Dunedin\",\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 3024,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/107722365252339049541/photos\\\"\\u003eOndrej Prokop\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAAUvzH2BpiOoNT0NrNR9ufhR08J7oRCASinag1DwA1TX2kxNbWiljwama84fxTHINYWOiAC-rMSknBdj5ibLPcYka_jfCEHtD1ug73YzYu8K6n3CE4qU8wpshtnggaNGSoEhCyOGqLK0_w_DmP4WgQwpI4GhTo4Cg29rKk17xD8GvlwVHAdSwYkw\",\n" +
                "               \"width\" : 4032\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJPVFfD-DkK6gRQZl5hIbvAAU\",\n" +
                "         \"reference\" : \"CmRbAAAAd7R8ynTXraTb6-4GQla6wOAaaQTihPTl8v80g066SCgzd3JkPA0YQWMKzYy3tzNwFlN6000DBN7t5-4NauGtRkJvT0J-hwlOOvy_AsXE9n6xJAQBdWtseoxh_dIDgXSsEhCJAFU1c95tfdqmPwLVBpg-GhRqWUuppTWHw9qEkbQMnYUBCCj7Fw\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [ \"locality\", \"political\" ],\n" +
                "         \"vicinity\" : \"Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.87277249999999,\n" +
                "               \"lng\" : 170.5007021\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.87142351970849,\n" +
                "                  \"lng\" : 170.5020510802915\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.87412148029149,\n" +
                "                  \"lng\" : 170.4993531197085\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/lodging-71.png\",\n" +
                "         \"id\" : \"c006bbe0a4c85b27d0239290e9281cbee47b06a7\",\n" +
                "         \"name\" : \"Kingsgate Hotel Dunedin\",\n" +
                "         \"opening_hours\" : {\n" +
                "            \"open_now\" : true,\n" +
                "            \"weekday_text\" : []\n" +
                "         },\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 600,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/102398435499887042102/photos\\\"\\u003eKingsgate Hotel Dunedin\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAAS8Jh5DufvOALM3shtjWrRsm8__0z5D60hu93R-RIBMg4813oZ4z6yhgmt4pKS4masfETQlg2praZAbQWSzUh2LAarUtbu-afggi4SXN2FZ_9pnrMKBlSGfk1SYtNcSaoEhCDz8wPdrhJnpQCqlo-xphCGhR1cBwfXWr4ZFTAlXM46uGx4j11Jg\",\n" +
                "               \"width\" : 900\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJkRuxlgysLqgRmNSHyzQyyDI\",\n" +
                "         \"rating\" : 3.5,\n" +
                "         \"reference\" : \"CmRRAAAA80XaJgyev-a1-lDrQ5BNbrk364JFHseh1Qu34zxlqlxw7XRU-d4h-fQom0sHF0zNk-LBmMNx1R_nRpWvwmupep7nLD2cDN-CvPKwtkGtrecd0eGbklWcFsLKPPgfoklTEhCg-z-7ATApEC-lQRTQSN7hGhTh502_lGfSngHqmoZl6BSps0cZjA\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [\n" +
                "            \"bar\",\n" +
                "            \"lodging\",\n" +
                "            \"restaurant\",\n" +
                "            \"food\",\n" +
                "            \"point_of_interest\",\n" +
                "            \"establishment\"\n" +
                "         ],\n" +
                "         \"vicinity\" : \"10 Smith St, Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.89764699999999,\n" +
                "               \"lng\" : 170.516806\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.8963406697085,\n" +
                "                  \"lng\" : 170.5181572802915\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.89903863029149,\n" +
                "                  \"lng\" : 170.5154593197085\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/lodging-71.png\",\n" +
                "         \"id\" : \"309015328a9f52db8c2a1d1c33cb35bb1ffedc83\",\n" +
                "         \"name\" : \"Arcadian Motel\",\n" +
                "         \"opening_hours\" : {\n" +
                "            \"open_now\" : true,\n" +
                "            \"weekday_text\" : []\n" +
                "         },\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 3264,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/108755474150884502048/photos\\\"\\u003eANDREW BAIRD\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAA8VbQzfGMjzkcGK6QbIg-pSrkf6cGBXv943IuCqY4LJAjxzWjhogFB-_7WN8x6wz8gAVvcLC85qPJdE0Ll2j2TNthADuYkmKJxcd3cKJakZXBGP6Y6PcKbzJq7TEPtGrjEhAUfFy7uGFKrm04HRMxh-p6GhScGKyZY2iRZXbDoPLae_t3cUbzIw\",\n" +
                "               \"width\" : 2448\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJbwl8k5uuLqgRhfOOuH7V9UI\",\n" +
                "         \"rating\" : 4.8,\n" +
                "         \"reference\" : \"CmRRAAAACRNo-UqrOuvy3bZJd6wEMQoVrIR2t4ERiOZLavO05wYGBXn138oZotbY_KGaRWM1HBdEXue9MMaZ4Ec2Mzl_9tNcYGcRzUsfzWsfMpsLkjlF-ce4vtTB_gguetiigGKmEhAiKcE6FWNVseZqx_8e9BnOGhRKqY94vliQIzBZI1qE3TqBxNuuHg\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [ \"lodging\", \"point_of_interest\", \"establishment\" ],\n" +
                "         \"vicinity\" : \"85 Musselburgh Rise, Musselburgh, Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.8612025,\n" +
                "               \"lng\" : 170.5105082\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.8598977697085,\n" +
                "                  \"lng\" : 170.5120200302915\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.8625957302915,\n" +
                "                  \"lng\" : 170.5093220697085\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/lodging-71.png\",\n" +
                "         \"id\" : \"59de4cb775ab1386892b8b061daad02ef061c539\",\n" +
                "         \"name\" : \"ASURE 755 Regal Court Motel Dunedin\",\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 1536,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/115519407644050135249/photos\\\"\\u003eASURE 755 Regal Court Motel Dunedin\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAAvoBvPy6E2TzAVB5e9Ya1gSMQvFUILpf1_R_Gd9S_RlbCjKGOh5xz25nEC5EnEn4b3IMHI0JtjpNKdvsfN6xa1lxZZ-_ZUGw7BDsidXuGIkQwtb5GKk6d2eoNkNsYF91CEhBdBf-SJSmkecyP53FCZPtJGhTSoZWWF4eYJksqO3o2GdTP00Kysg\",\n" +
                "               \"width\" : 2048\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJj_69OGWsLqgRzX816m7XAsw\",\n" +
                "         \"rating\" : 3.2,\n" +
                "         \"reference\" : \"CmRSAAAAiUhZI3pItfLuCD7_iQi_lkqc_q3K8v1q8VRkMxei4Py3MQcv4waS8DkWCcwdl0yucnY4VWeK0zLqkjAgi7QgNMogLhRz4fOarDa5c99y5mMs5OfQMR69ilhYzzvzda5fEhBFzlwuPweD6ISQvFMLwrVgGhSbZ97qJULDyAyP_UwH8yZ8o840xA\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [ \"lodging\", \"point_of_interest\", \"establishment\" ],\n" +
                "         \"vicinity\" : \"755 George Street, North Dunedin, Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.87785,\n" +
                "               \"lng\" : 170.501113\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.8765602697085,\n" +
                "                  \"lng\" : 170.5024994802915\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.8792582302915,\n" +
                "                  \"lng\" : 170.4998015197085\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/lodging-71.png\",\n" +
                "         \"id\" : \"711e9dbca814efaa9f770783bd2c933f65fb9825\",\n" +
                "         \"name\" : \"Scenic Hotel Southern Cross\",\n" +
                "         \"opening_hours\" : {\n" +
                "            \"open_now\" : true,\n" +
                "            \"weekday_text\" : []\n" +
                "         },\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 2671,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/117215597357508110890/photos\\\"\\u003eScenic Hotel Southern Cross\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAAxAFtE9KkZBPheCKc5vJ8SNG0kOUxlqp8tcJFywV6cMJj_vM2V0ff20aBmjqNsBtB3LbZlft5LpFGNfLrBQAD7IX2jXl4FNWMChgTkoP8bzksGCq2bMp4lKh6MJvyPokgEhC08Ppi-HLGDSXkrR9-OJV2GhQnQGsLiAnPuiRAbMzwaX4zWRK2pw\",\n" +
                "               \"width\" : 3849\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJefPlWA6sLqgRKGk2vdv3iSE\",\n" +
                "         \"rating\" : 3.9,\n" +
                "         \"reference\" : \"CmRRAAAA7kcE13fnsOY3QXAYOamBhmKg7CMdPGGR-wAxbmz91q4SzDIIcTbVABm6AKfo3jRe_r07CZD1KO9VM8rYRKe99pzNrtkuSFohrNfvB1Wta7LVjqQyKP7SbN1ox_g2yKxIEhA90NTz6qKNP7YaBzY4GugVGhQgig8DTmnTX490U2p4mo4YirBJnQ\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [ \"lodging\", \"point_of_interest\", \"establishment\" ],\n" +
                "         \"vicinity\" : \"118 High Street, Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.876244,\n" +
                "               \"lng\" : 170.5025462\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.87487926970849,\n" +
                "                  \"lng\" : 170.5038388302915\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.87757723029149,\n" +
                "                  \"lng\" : 170.5011408697085\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/lodging-71.png\",\n" +
                "         \"id\" : \"358e5ef0ad015933f68c9dc61da4d21573acd1cf\",\n" +
                "         \"name\" : \"Scenic Hotel Dunedin City\",\n" +
                "         \"opening_hours\" : {\n" +
                "            \"open_now\" : true,\n" +
                "            \"weekday_text\" : []\n" +
                "         },\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 2048,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/107305582896003649616/photos\\\"\\u003eScenic Hotel Dunedin City\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAAhgqSa5yQfXGL7E-F753a63oXPqMnlSnlLPAh3fmeRsdAjt30NMFKa65KA95ob-Kvde5ZCOwVV0_7XoFHGblxPy_ObjpTX361mPN1fT55ShGE8O10dt9XIkv5_JrKFpj3EhD6a7cRJYrU0dKYokm7cfN-GhSJuHUeTmqyBbvCHN4trfmCc_SNDA\",\n" +
                "               \"width\" : 1365\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJma2r2A2sLqgRsA7eGYr7a0o\",\n" +
                "         \"rating\" : 3.9,\n" +
                "         \"reference\" : \"CmRRAAAAyTEXPa67qbbDWdmFAP4sxyQQnsvAwsI8UMsnECHM12vj97QC7UDNZ4uKig44Zs8Zoaf8pEhTziwOE2980WAltPn9H00c-vswuyjXTJSIv9MwEFOogSW5o7KrptUWmgP8EhAVYd6OjVQ4xhIUhQvA_DbTGhTz-y4biLF7YokCZCgO8-zby2qOAg\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [ \"lodging\", \"point_of_interest\", \"establishment\" ],\n" +
                "         \"vicinity\" : \"123 Princes Street, Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.87249999999999,\n" +
                "               \"lng\" : 170.50749\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.87115101970849,\n" +
                "                  \"lng\" : 170.5088389802915\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.87384898029149,\n" +
                "                  \"lng\" : 170.5061410197085\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/lodging-71.png\",\n" +
                "         \"id\" : \"570af8fb407ae2c6fe9549760425de6fa0b85f9c\",\n" +
                "         \"name\" : \"The Victoria Hotel Dunedin\",\n" +
                "         \"opening_hours\" : {\n" +
                "            \"open_now\" : true,\n" +
                "            \"weekday_text\" : []\n" +
                "         },\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 3264,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/101079619907007804489/photos\\\"\\u003eThe Victoria Hotel Dunedin\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAAM8OH7Bx0mFWo4E2cgW4xsAHivtMUEw4E87uRxKi-AzeJryKPCYL3eE0-CXpV-TEDDh4d578uyZr0PCQFI5cGUa_SxAigsnVnCTcAUzGgG-06xJL_bta_brwrMfXJOljsEhCMAd4UoEz67kEUXzInYs3rGhTVgd6Y2yNPHElpejHmn2eQOjOlrQ\",\n" +
                "               \"width\" : 4912\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJpZwfxhKsLqgRlRmS9oForfQ\",\n" +
                "         \"rating\" : 4.5,\n" +
                "         \"reference\" : \"CmRSAAAAh-6sLbVaDjrXBZ78HNSnwKwxd6ywTd911TaLEu3WLz_r5xVT15E4m-cCLt1MJ43r42ZvEv2NLUHivrN1b5dtwq_MObdWGX9qAkQ5HHkejbVQ6AjHVkekqBQYVYScuGqWEhAoSNOsq-SOwPLSxkeJ9WbqGhTRqrnZCWW1UCRcLYyr8Q_S_ip0uw\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [ \"lodging\", \"point_of_interest\", \"establishment\" ],\n" +
                "         \"vicinity\" : \"137 St Andrew Street, Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.89994,\n" +
                "               \"lng\" : 170.48099\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.8986113197085,\n" +
                "                  \"lng\" : 170.4823665802915\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.9013092802915,\n" +
                "                  \"lng\" : 170.4796686197085\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/lodging-71.png\",\n" +
                "         \"id\" : \"30b85f18d16cc39f54232937c709f6e4fe346781\",\n" +
                "         \"name\" : \"Hazel House Boutique Bed & Breakfast\",\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 384,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/106744244113270434655/photos\\\"\\u003eHazel House Boutique Bed &amp; Breakfast\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAAC8Sh9QR5wbqptew6zcMNkvg79XtFGv5MYm_GDvsoCr-OrpS0mPgHsaD30nEAdBF6gvcpZr2M-Bgrs7lceMgBMzkxgxmdgOk9wOnHx9RV0eYKDCXfoAe--CExMHvePyd3EhBGHBscXu3YUxwdlqOkkHIFGhRVUOSVXL6Pypzdl0HrNlAEew4wDQ\",\n" +
                "               \"width\" : 512\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJs6dLpE2pLqgR88HkaTNMAbM\",\n" +
                "         \"reference\" : \"CmRSAAAAnYAiE7rLFnav4Z9_ZKD7LOihmXfQcdcVpXsj67j4wFguN94mRRrlsac9b9wq2r-cIShwskDSPc9B0XpJl4URhPUY0JSVwiUHES3DjVMWnTra4G0hJ1RoaOUeKSJ8rFASEhCdO8tnMxACfo9mKFUFSPNmGhRdFAtY2TrmwSuBAKQw3qYxZmvHcw\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [ \"lodging\", \"point_of_interest\", \"establishment\" ],\n" +
                "         \"vicinity\" : \"50 Hazel Avenue, Caversham, Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.896153,\n" +
                "               \"lng\" : 170.526019\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.8946799197085,\n" +
                "                  \"lng\" : 170.5271881802915\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.8973778802915,\n" +
                "                  \"lng\" : 170.5244902197085\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/lodging-71.png\",\n" +
                "         \"id\" : \"79e5387b07c3a16c0c6e662cfd19dc3813f2bad4\",\n" +
                "         \"name\" : \"Bayfield Motels\",\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 432,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/110869822918693324004/photos\\\"\\u003eBayfield Motels\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAA4465NrefgP2ijlTP6LA22XXDb9dXaRjnIIORFUUgSsgCnMC1jd8FvyVAvs_Oh4iqyay_E4PtoGq7rK5A_52_nhWTY45F3d5uZl-iM79Suo9Uk4A_SX5saYM9Z7ChwVr8EhApR_uxcFORCwhqHJlZXxauGhRqFRXc2tukra1N4Wwwc-LNRQNtBg\",\n" +
                "               \"width\" : 576\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJkdQOwIOuLqgRS9G9raCTZTc\",\n" +
                "         \"rating\" : 4.3,\n" +
                "         \"reference\" : \"CmRRAAAAGDjDx1_8pCxE8yYA0jYsY167gMv9Zg0HuaFtHEWPvX4GJbgVWuFaeTviqWsh_EkqHvtVVpYD-gh3szbkUK4Xz_0JaTPWkJfuu5MEEuBm8cIQFkA4RIQFjQvzZ6WsR_3nEhDX66_3PSMy2VNKB0CHfNQyGhQ2zx3iStmKXoF_GPiMGhy-rujKbA\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [ \"lodging\", \"point_of_interest\", \"establishment\" ],\n" +
                "         \"vicinity\" : \"210 Musselburgh Rise, Andersons Bay, Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.876516,\n" +
                "               \"lng\" : 170.505734\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.8753070197085,\n" +
                "                  \"lng\" : 170.5069958302915\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.8780049802915,\n" +
                "                  \"lng\" : 170.5042978697085\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/lodging-71.png\",\n" +
                "         \"id\" : \"cfcd6d84cdee62a802026c1220f6cb8a568db9af\",\n" +
                "         \"name\" : \"Leviathan Hotel\",\n" +
                "         \"opening_hours\" : {\n" +
                "            \"open_now\" : true,\n" +
                "            \"weekday_text\" : []\n" +
                "         },\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 336,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/100809719946177025936/photos\\\"\\u003eLeviathan Hotel\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAAUjMHNe4TpyM92Au6Z4JLDWJ1K8F8SnT1oqi-Eg9QutmbpqUuRZYGCQGt5I_HOx2gxzLke5Sv2Y-4eXscOuG6s4axGhCTLKAYY65-7zlsZHzjeCd8hG5wffhojY64tOIEEhCq4qAzsExnvOQlN34DqRwaGhQqZCxpe0G10sCACGHnbjWP_J0Xog\",\n" +
                "               \"width\" : 448\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJKysZ9RGsLqgRG7c67N4rw0I\",\n" +
                "         \"rating\" : 3.7,\n" +
                "         \"reference\" : \"CmRRAAAAylfPfWwJTbdYwz0W08Lx6LzjnNnKpaCx2k2jPPuYogK5DTJn36pvzlbselzbZqtvSx-Dl3_9RvzCRNd-FdqShueBcnuYmj1bGVb3ETeZDsIzfViLhaN8o1zgAj6VaZcgEhD3bEpdOEFy7ifadkSr2PeaGhRCnczdalStuhjuN-gp7ZaRpSLBpw\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [ \"lodging\", \"restaurant\", \"food\", \"point_of_interest\", \"establishment\" ],\n" +
                "         \"vicinity\" : \"27 Queens Gardens, Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.8723791,\n" +
                "               \"lng\" : 170.5027761\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.8710425197085,\n" +
                "                  \"lng\" : 170.5041809802915\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.8737404802915,\n" +
                "                  \"lng\" : 170.5014830197085\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/lodging-71.png\",\n" +
                "         \"id\" : \"a21db9c3d17265a3cd20f429e6965554e906db9e\",\n" +
                "         \"name\" : \"On Top Backpackers\",\n" +
                "         \"opening_hours\" : {\n" +
                "            \"open_now\" : true,\n" +
                "            \"weekday_text\" : []\n" +
                "         },\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 693,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/109799608007304684144/photos\\\"\\u003eOn Top Backpackers\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAA6KrgcFCjbgMtAjQfYYGI9w-DkYgumD3BHQYeM82fGyNhcx55kgsmS4NiK2U62v0JxsfWACcKXUaYGq24YNf2OcAdEhC8HAUz0UcUnpNOpdZVwVcgzgqq1aIGI3EChCgZEhCkKIanFJPiJenyTasXYuC-GhSfuHEKcx6ug2az8d_7dARS08F8Hg\",\n" +
                "               \"width\" : 1080\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJ93a62AysLqgR7aIxcOxk20o\",\n" +
                "         \"rating\" : 3.4,\n" +
                "         \"reference\" : \"CmRRAAAAWdr8exN_VNRSFoVPnHJn-9wzCGq8UScnxn5ab9k9Mf_DmtiAuDQR8r81n3ux2TnRm254BQpjA4tzB1zLIsWpLh6odS8boghksgkEqJuwMAaLoZ72kXxghJvxJ70VT9NOEhDkqvoAz4BCF8GuW-YqpUOaGhRmS45H3s5FYAY7OBFLyN6xjF6QXQ\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [ \"lodging\", \"point_of_interest\", \"establishment\" ],\n" +
                "         \"vicinity\" : \"12 Filleul Street, Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.85707610000001,\n" +
                "               \"lng\" : 170.5156002\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.8557271197085,\n" +
                "                  \"lng\" : 170.5169491802915\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.8584250802915,\n" +
                "                  \"lng\" : 170.5142512197085\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/lodging-71.png\",\n" +
                "         \"id\" : \"724e63e81ab301e637413c017f5c29ddac8d52ca\",\n" +
                "         \"name\" : \"Mercure Dunedin Leisure Lodge\",\n" +
                "         \"opening_hours\" : {\n" +
                "            \"open_now\" : true,\n" +
                "            \"weekday_text\" : []\n" +
                "         },\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 768,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/103388644722843100276/photos\\\"\\u003eMercure Dunedin Leisure Lodge\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAAPOJHtwIPvewQV9prUajnaOSu_E3aNqEKpl6PfiFjuKfKRSuf9KyUnebB4L71WHAZfqYEYzI4noyV6NsDHDWGqR5bfbWoh2Y2ytpcA2j6w0T17v9Q5yvIYfRkqim02X4OEhD1ABfa4bjAq3nQqWFETXNJGhQgtC56Gfg0rkVM2khjHlBr7smEUQ\",\n" +
                "               \"width\" : 1024\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJxaJ48GOsLqgRLhVugQEf4oU\",\n" +
                "         \"rating\" : 4,\n" +
                "         \"reference\" : \"CmRSAAAA9BIBs2v3pBrfGNX0nMRXuCYEQZ2QKIxQHV5_G9WSsCYjZ_sgdN50GvzZtDMnlN_VsNNFv_JYZFsC9Cmis01z3ZWg1VohGbU6X9OhCmFqHz3J8bJiVtLNSbgzpDJHGbPKEhAtDZz9D1oBIgwBCBV9-6pRGhSu5v3GHPcZicWunBu-LxaYx84X2Q\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [ \"lodging\", \"restaurant\", \"food\", \"point_of_interest\", \"establishment\" ],\n" +
                "         \"vicinity\" : \"30 Duke Street, North Dunedin, Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.9059018,\n" +
                "               \"lng\" : 170.5087492\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.9045085697085,\n" +
                "                  \"lng\" : 170.5102066302915\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.90720653029149,\n" +
                "                  \"lng\" : 170.5075086697085\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/lodging-71.png\",\n" +
                "         \"id\" : \"b724b4935aefec57f5998071651b3ba9e014d8cb\",\n" +
                "         \"name\" : \"Ocean Beach Hotel\",\n" +
                "         \"opening_hours\" : {\n" +
                "            \"open_now\" : true,\n" +
                "            \"weekday_text\" : []\n" +
                "         },\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 3376,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/109714311264348542891/photos\\\"\\u003eSteven Chueh\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAAXurVWxoPXH8YtWUEBw80SP3QgXeXiLEIe5UmNJOOkQ2iSNrsOTjeMruyzlO45CzaMdajm62U48rXi6SLhliofy9xhCF9l-Ejxw7IamOIMI31Q6nXJFibxhIPi1qdY7wlEhDiDnFXFLEzOx5dMsr_AY0aGhSjIr4hzAaSOw327zeNxDUuISWR7w\",\n" +
                "               \"width\" : 6000\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJq8XX0JWuLqgRzhvTZt8sEmw\",\n" +
                "         \"rating\" : 4,\n" +
                "         \"reference\" : \"CmRRAAAAATNbv0Y6YsiLsz6O9zEcHdbpqp_x2AvkOS1ZGgMz2JjgXyLasFbdA7Xges6bKKh8GDIA7YaKkCvQ2DVIAsz6R-4S3dccLi8dZdlfJHturScslSl8Mwp-qAHlJlBRsPEnEhDo9RF4yi7Ic6CqkS89wjN4GhRzvjVSiKJmUj5O3lnQmtHQPFBBWg\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [\n" +
                "            \"bar\",\n" +
                "            \"lodging\",\n" +
                "            \"restaurant\",\n" +
                "            \"food\",\n" +
                "            \"point_of_interest\",\n" +
                "            \"establishment\"\n" +
                "         ],\n" +
                "         \"vicinity\" : \"134 Prince Albert Road, Saint Kilda, Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.897312,\n" +
                "               \"lng\" : 170.5092\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.8959352697085,\n" +
                "                  \"lng\" : 170.5105898802915\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.8986332302915,\n" +
                "                  \"lng\" : 170.5078919197085\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/lodging-71.png\",\n" +
                "         \"id\" : \"c01877d02103d2c5ffa217a709f4b996f516c393\",\n" +
                "         \"name\" : \"Best Western 555 on Bayview\",\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 2992,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/114668591369208902375/photos\\\"\\u003eBernard Tan\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAA3M-mIvilOH0jjpjSlpdwU0JclH6Ye524hIHXKm2xhkjhWI1HjCNXeHotw6vOXuecfTExnODawszGo5M0jj7_7V2LHrIe0_8uiRBbMdV3vAHyz4wtXjU-8uMnLsSYuJvoEhAb5hAxe1ogzJ4k2761qp_yGhTfyM7sv_u3nUPs0V-8qZ2FJyeUlQ\",\n" +
                "               \"width\" : 4000\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJ84W8daKuLqgRJGHwzILG9MY\",\n" +
                "         \"rating\" : 4.5,\n" +
                "         \"reference\" : \"CmRSAAAAVO3IaI-y11DIaT1o-1z-mcuUnLV0xK68JvEdnKrPFEC41sKdcxFRNNS7RIAf0NCMN7ht9cxohSFHVfm5bcjNGZrjNkpux8taS6D4mLtsTyS47gQ5eWHH1i--QBjY5SOYEhC3QqWsReIWikIBT8NzMpG1GhRlRdRH-lWwp_MWv_4KP4zAR1tKfQ\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [ \"lodging\", \"point_of_interest\", \"establishment\" ],\n" +
                "         \"vicinity\" : \"555 Andersons Bay Road, South Dunedin, Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.871557,\n" +
                "               \"lng\" : 170.501741\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.87027991970849,\n" +
                "                  \"lng\" : 170.5031420302915\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.87297788029149,\n" +
                "                  \"lng\" : 170.5004440697085\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/lodging-71.png\",\n" +
                "         \"id\" : \"d8d6d6b41da36e5abd3c30577bf8b5122fe9e22b\",\n" +
                "         \"name\" : \"Motel On York\",\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 3456,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/115801287864506491280/photos\\\"\\u003eEoin McDonald\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAA4Pp3kBCBD5VIVXBTIHQGH27UBdff6-RntPrMPuZ_O3EmzhzOt_bFi7k0QGaSWEJ9v5gWhBik-rX3RyK2qeLO5c5ANbXc-fbNYOvN09GAXyzPcPCXqxiU3d9NAVZe7HrOEhCro0-EkzGp4mqbz9yo6gv9GhQwn0uTqHqcRxX8BnE6nXSWDbjdIw\",\n" +
                "               \"width\" : 5184\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJg9G8ygysLqgRQt_KQa6ev2s\",\n" +
                "         \"rating\" : 4.3,\n" +
                "         \"reference\" : \"CmRRAAAAM1TO00lETvDuhX5r4PbX3PRHFs_ZMm-0HgLBavzWC-09B5mD1YQqX7QDB2E1lCf7MlrZl6cTOAink6umIWwoK95P8x4Rz5FUF7SjvYLce0U-JEpZQ2Gngp24IIeqTHEtEhBH2U0ajvVHT00eDUctom5mGhTKP5O6IvdqL9_95cHwdR1wwH6GtA\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [ \"lodging\", \"point_of_interest\", \"establishment\" ],\n" +
                "         \"vicinity\" : \"47 York Place, Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.863773,\n" +
                "               \"lng\" : 170.50938\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.8624240197085,\n" +
                "                  \"lng\" : 170.5107289802915\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.8651219802915,\n" +
                "                  \"lng\" : 170.5080310197085\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/lodging-71.png\",\n" +
                "         \"id\" : \"0eaa18e22241b5ad879e52a2231f14c34dc7a9e5\",\n" +
                "         \"name\" : \"Sahara Guest House\",\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 3120,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/117460288215380139977/photos\\\"\\u003eРуслан Торобаев\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRZAAAA8WQLKiKqjwSzzSzRIwxO4RHE3EjW4B00x6SkkCkALD_YjZ6JyAc2b-jxZEbHZIFDEyO2NpOp7mPEc-1ZHHCBL64-i0GEEm-oc2Zx-zLaXQebH6z11U5_Ie9jIE_SPYDbEhAHK5IAsIT9R3FZwSKEm8u3GhSkGflI2wRZfzqWq4Gj1NMG5uPQMA\",\n" +
                "               \"width\" : 4160\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJk-UG3W-sLqgRFoN19YLlEGE\",\n" +
                "         \"rating\" : 4,\n" +
                "         \"reference\" : \"CmRRAAAAI4oIf-SAoG_dFgN9UlNWqX5WJtW9ABBMp1rblEzOlqthQ3QOuOUix23OGfTfOgp7Lu1-kRiJl7AYgw-hU1pPNKwH01e41gHkPYfUSvpLO2U5k-8PDD6iAS12r_lX9t8vEhDO8II7Eg5fMdVoLF96fXEKGhRDH0PNYevwnG3Xp55te1uBBx967w\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [ \"lodging\", \"point_of_interest\", \"establishment\" ],\n" +
                "         \"vicinity\" : \"619 George Street, Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.8646678,\n" +
                "               \"lng\" : 170.5080263\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.8634271697085,\n" +
                "                  \"lng\" : 170.5097640802915\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.8661251302915,\n" +
                "                  \"lng\" : 170.5070661197085\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/lodging-71.png\",\n" +
                "         \"id\" : \"720b0f2107fe3185deaefd19ffb1addd0906eaa1\",\n" +
                "         \"name\" : \"Bluestone On George\",\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 1152,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/111816712369865864312/photos\\\"\\u003eliu kus\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAAN7PVry8pGhRledWPDjbtvKJ-6m9lhh8hSeqJrjo6xQ9qXEWqGSuj62EnR9fRB-loRJg6E8FxNMDxp0ExfxT9qLZH5lOKTpList2V1C8VCv2MAWCs10bYJj7Rzz349BnsEhAAQARNKY0sPPipvsPwOeYZGhTVBW9PbLOM6twrk9L2zvCE2ktOsQ\",\n" +
                "               \"width\" : 2048\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJCexnK3CsLqgRGuGRWCA83_A\",\n" +
                "         \"rating\" : 4.4,\n" +
                "         \"reference\" : \"CmRSAAAAz8yEt56uEd1Efsf56wgqqzZLhEipfuwW82cAUqrCSLDRb58Ai3HtRBVxFcDZg29_CZz29Aa6aWMdcbQZbdxU2wJmJ464wYFbIZFEJfnGqgQn06pl4vEBg2E1J8Nz8mAKEhCB-6rUdMt-kzOpWO2F7cj-GhQAnaEmLDMFlZTsYGWMQL0uRGTUtg\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [ \"lodging\", \"point_of_interest\", \"establishment\" ],\n" +
                "         \"vicinity\" : \"571 George Street, North Dunedin, Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.85830000000001,\n" +
                "               \"lng\" : 170.516459\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.8569510197085,\n" +
                "                  \"lng\" : 170.5178079802915\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.8596489802915,\n" +
                "                  \"lng\" : 170.5151100197085\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/lodging-71.png\",\n" +
                "         \"id\" : \"875684f943711ab244731d41addc641fd13d0551\",\n" +
                "         \"name\" : \"Commodore Motel\",\n" +
                "         \"opening_hours\" : {\n" +
                "            \"open_now\" : true,\n" +
                "            \"weekday_text\" : []\n" +
                "         },\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 1365,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/102215635332404049467/photos\\\"\\u003eCommodore Motel\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAATQWyaXs8w6xh4Q2B_qRPNenUUgceoGkAn6iiALkvbX8xyzcz3RAM_BnJ8Nrd8f6OFbPHsWgKsMz-hrOoAjHccOttUyf_2Ffj9xrVaLzmtKITuSNAu4ZGPq0LTRSDaWxEEhANs1tZZaLvHn0hChz8FO5fGhT-6Hm3RqYETKGr31Ph3ZIHBo97KQ\",\n" +
                "               \"width\" : 1365\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJx6k2AWSsLqgRlofOOqH2rTg\",\n" +
                "         \"rating\" : 4.2,\n" +
                "         \"reference\" : \"CmRRAAAAIxCwDibM8wGxok3cH--HP0_R5OttQBQuDI1k4XVbW267n-sUJ8nUKG3L81VekNvYEELCj0M8POVFgs_JH4fdc5ZqCkkPd1PYDrjzuLwmFC-iNLybU_6LFaCIry6QMe9wEhCBhm41M6b2JpxVU_iL0EycGhTiACoM6kabZgpald8z4h6OxdNBug\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [ \"lodging\", \"point_of_interest\", \"establishment\" ],\n" +
                "         \"vicinity\" : \"932 Cumberland Street North, Dunedin North, Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.8749589,\n" +
                "               \"lng\" : 170.4973092\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.8736099197085,\n" +
                "                  \"lng\" : 170.4986581802915\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.87630788029149,\n" +
                "                  \"lng\" : 170.4959602197085\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/lodging-71.png\",\n" +
                "         \"id\" : \"23029c41f1fbc3d101a8daecf73e821272579cfc\",\n" +
                "         \"name\" : \"The Brothers Boutique Hotel\",\n" +
                "         \"opening_hours\" : {\n" +
                "            \"open_now\" : true,\n" +
                "            \"weekday_text\" : []\n" +
                "         },\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 424,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/107729968199944579943/photos\\\"\\u003eThe Brothers Boutique Hotel\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAAQY6rnC2hFM1eJPuAOTZE7T7depEfnRGIt5eYfSNIsRTqLGOV2aP-g04X7rNSW52zct3Me5QoRcZs2bISJziZXIpLBgPUhJii3XhlRwBLYeZNiTSq3ZQwsX2JOkBFOFONEhAQrQiXraAsIaGMyCl2AnzWGhTKzEy2z6hWR8Mczrg95iaDfWrJFQ\",\n" +
                "               \"width\" : 640\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJ376X6QusLqgRhO6jI90aUfw\",\n" +
                "         \"rating\" : 4.2,\n" +
                "         \"reference\" : \"CmRSAAAArO8MSVLP7Nv8tl6WaA2IsmnQnEPINmF4Qek1_bHnYeECBO0NNoscklLg2P6bTEPkM1zc1sxwKdpNhVfGaYVJRO11zSRp6-XOmWhrkMH7mE3vWGQQyVaVe2e_J7BW1ndMEhAXApPfdHLtHfpmuyOfdD_pGhR1HFkmbir6dVp4SGphAhZvo5_1aQ\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [ \"lodging\", \"point_of_interest\", \"establishment\" ],\n" +
                "         \"vicinity\" : \"295 Rattray Street,, Car park location - GPS directions 10 Bishops Road, Dunedin\"\n" +
                "      },\n" +
                "      {\n" +
                "         \"geometry\" : {\n" +
                "            \"location\" : {\n" +
                "               \"lat\" : -45.87876050000001,\n" +
                "               \"lng\" : 170.5027976\n" +
                "            },\n" +
                "            \"viewport\" : {\n" +
                "               \"northeast\" : {\n" +
                "                  \"lat\" : -45.8646985,\n" +
                "                  \"lng\" : 170.5386176\n" +
                "               },\n" +
                "               \"southwest\" : {\n" +
                "                  \"lat\" : -45.8912148,\n" +
                "                  \"lng\" : 170.4847183\n" +
                "               }\n" +
                "            }\n" +
                "         },\n" +
                "         \"icon\" : \"https://maps.gstatic.com/mapfiles/place_api/icons/geocode-71.png\",\n" +
                "         \"id\" : \"3e7449dc32cafe95c74631dcbf4cdfcc25bbe1aa\",\n" +
                "         \"name\" : \"Dunedin\",\n" +
                "         \"photos\" : [\n" +
                "            {\n" +
                "               \"height\" : 2448,\n" +
                "               \"html_attributions\" : [\n" +
                "                  \"\\u003ca href=\\\"https://maps.google.com/maps/contrib/101768335166984548085/photos\\\"\\u003eJoana\\u003c/a\\u003e\"\n" +
                "               ],\n" +
                "               \"photo_reference\" : \"CmRaAAAAg5MAxRhdGyzLm05UEAbyoMO_gZy_53a83T-SfIc84Pgxtol46ZV-j8MVPvU02a74r4LhjfDKedPEkrO5x5zf2uZWyHzuRMqeuPF1qID-qLh4uRrOS5shlewBxrPIwZFnEhDUXId6GWQfYEA8Y2cpKv0zGhTtgrI6QOBof4f1_tdvcNZd41l0ng\",\n" +
                "               \"width\" : 3264\n" +
                "            }\n" +
                "         ],\n" +
                "         \"place_id\" : \"ChIJ89UFlBasLqgR8Gl5hIbvAAU\",\n" +
                "         \"reference\" : \"CmRbAAAAC-SQGLadXXWsy6c7Rr8V4OkJqKBH2Xrf2nt2KR6I5o9bHELmSkBTcO8YURE7cshiZmQqBLumSaQNhWl90hI5aChqQiVJxYiVEiE78TDEMENvUI2j2wkAccl3QuqK7YhKEhCG5r9Zd_gzx0AUPfvUOK1tGhQjS_OB7fOF837O7H-loetPiYkJkA\",\n" +
                "         \"scope\" : \"GOOGLE\",\n" +
                "         \"types\" : [ \"sublocality_level_1\", \"sublocality\", \"political\" ],\n" +
                "         \"vicinity\" : \"Dunedin\"\n" +
                "      }\n" +
                "   ],\n" +
                "   \"status\" : \"OK\"\n" +
                "}";
    }
}
